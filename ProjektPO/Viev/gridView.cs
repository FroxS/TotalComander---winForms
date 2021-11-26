using ProjektPO.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPO.Viev
{
    public partial class gridView : UserControl
    {

        private static Rectangle dragBoxFromMouseDown;
        private static object valueFromMouseDown;
        private PanelComander pc;
        //private TextBox tb;
        private Label lab;
        private ComboBox cmb;
        private TextBox search;
        private string lastNameBeforeRename;

        internal PanelComander Pc { get => pc; set => pc = value; }

        public gridView(ref object[] data)
        {         
            InitializeComponent();
            //tb = data[0] as TextBox;
            lab = data[0] as Label;
            cmb = data[1] as ComboBox;
            search = data[2] as TextBox;
            pc = new PanelComander(this.dataGrid, cmb.Text);
            lab.Text = pc.SourceDirectory;
            pc.fillGrid();
            
            this.cmb.SelectedIndexChanged += new EventHandler(this.changeDrive);
            this.search.TextChanged += new EventHandler(this.searchFiles);
            this.search.KeyDown += new KeyEventHandler(this.searchFilesDel);
            dataGrid.CellValueChanged += new DataGridViewCellEventHandler(this.renameRow);

        }

        

        private void changeDrive(object sendler, EventArgs e)
        {
            if (Directory.Exists(cmb.Text))
            {
                pc.SourceDirectory = cmb.Text;
                pc.fillGrid(true);
                lab.Text = pc.SourceDirectory;
            }
            
        }

        private void searchFiles(object sendler, EventArgs e)
        {
            if (!string.IsNullOrEmpty(search.Text))
            {
                pc.fillGrid(search.Text);
            }

        }

        private void searchFilesDel(object sendler, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) && search.Text.Length == 1)
            {
                if (!string.IsNullOrEmpty(search.Text))
                {
                    pc.fillGrid("*");
                }
            }           
        }


        //Grid from drop
        private void dataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            //Pobranie indexu zabranej komórki
            var hittestInfo = dataGrid.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1 && hittestInfo.RowIndex != 0 && hittestInfo.ColumnIndex != 0)
            {
                valueFromMouseDown = dataGrid.Rows[hittestInfo.RowIndex].Cells[0].Value;
                if (valueFromMouseDown != null)
                { 
                    Size dragSize = SystemInformation.DragSize;
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset 
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        //Grid from drop
        private void dataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {                  
                    DragDropEffects dropEffect = this.dataGrid.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        //Grid to drop
        private void dataGrid_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGrid.PointToClient(new Point(e.X, e.Y));

            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                if (!(valueFromMouseDown is null))
                {
                    var hittest = dataGrid.HitTest(clientPoint.X, clientPoint.Y);

                    if (!(pc is null) && hittest.RowIndex != -1 && hittest.ColumnIndex != -1)
                    {

                        if (!pc.isTheSameSource(cellvalue))
                        {
                            TotalComander parentForm = (TotalComander)GetParentForm(this);
                            if (!isDirectory(cellvalue))
                            {

                                if (parentForm.chboxMove.Checked)
                                    pc.pasteFile(cellvalue, "move");
                                else
                                    pc.pasteFile(cellvalue, "copy", parentForm.chboxOverwrite.Checked);
                            }
                            else
                            {
                                if (parentForm.chboxMove.Checked)
                                    pc.pasteDirectory(cellvalue, "move");
                                else
                                    pc.pasteDirectory(cellvalue, "copy");
                            }

                            parentForm.refreshAllGrids();
                        }

                    }


                }
                else
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (!(files is null))
                        MessageBox.Show(files[0]);
                }


            }
        }
        private bool isDirectory(string file)
        {
            FileAttributes attr = File.GetAttributes(file);
            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }

        //Grid to drop
        private void dataGrid_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Grid to drop
        private void dataGrid_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private Form GetParentForm(Control parent)
        {
            Form form = parent as Form;
            if (form != null)
            {
                return form;
            }
            if (parent != null)
            {
                // Walk up the control hierarchy
                return GetParentForm(parent.Parent);
            }
            return null; // Control is not on a Form
        }

        //Grid go deep
        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string path;
                if (pc.Dgv[0, e.RowIndex].Value is null)
                    pc.fillGrid();
                else
                {
                    if(isDirectory(pc.Dgv[0, e.RowIndex].Value.ToString()))
                    {
                        if (e.RowIndex == 0) pc.GoBack = true;
                        path = pc.Dgv[0, e.RowIndex].Value.ToString();
                        pc.go(path);
                    }
                }
                lab.Text = pc.SourceDirectory;
            }
        }

        //Grid don't sort 'back button'
        private void dataGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.RowIndex1 == 0)
                e.Handled = true;
            else
                e.Handled = false;
        }

        //Grid function delete,create
        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.F8)
            {
                if (!(pc is null))
                {
                    foreach (DataGridViewRow file in this.dataGrid.SelectedRows)
                    {
                        if (isDirectory(file.Cells[0].Value.ToString()))
                            pc.deleteDirectory(file.Cells[0].Value.ToString());
                        else
                            pc.deleteFile(file.Cells[0].Value.ToString());
                    }
                    pc.fillGrid();
                }
            }

            if (e.KeyCode == Keys.F7)
            {
                if (!(pc is null))
                {
                    using (WinGetName settingsForm = new WinGetName())
                    {
                        if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            pc.createDirectory(settingsForm.Value);
                            pc.fillGrid();
                        }
                    }

                }
            }
        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {

            if(e.Button == MouseButtons.Right)
            {
                var hti = dataGrid.HitTest(e.X, e.Y);
                dataGrid.ClearSelection();
                dataGrid.Rows[hti.RowIndex].Selected = true;
            }               

            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                if(this == ((TotalComander)GetParentForm(this)).LeftPanelGrid)
                    ((TotalComander)GetParentForm(this)).RightPanelGrid.dataGrid.ClearSelection();
                else
                    ((TotalComander)GetParentForm(this)).LeftPanelGrid.dataGrid.ClearSelection();
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();               

                int currentMouseOverRow = dataGrid.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    
                    m.MenuItems.Add(new MenuItem("Zmień nazwę") { 
                        Tag = currentMouseOverRow
                    });
                }

                m.Show(dataGrid, new Point(e.X, e.Y));
                m.MenuItems[0].Click += new EventHandler(this.RenameFille);

            }
        }

        private void RenameFille(object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi is null) return;
            dataGrid[2,(int)mi.Tag].ReadOnly = false;
            lastNameBeforeRename = dataGrid[0, (int)mi.Tag].Value.ToString();
            dataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGrid.BeginEdit(true);
        }

        private void renameRow(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //if (isDirectory(lastNameBeforeRename))
                DataGridView dvg = sender as DataGridView;
                string newName = Path.GetFileNameWithoutExtension(dvg[e.ColumnIndex, e.RowIndex].Value.ToString());
                string newPath = Path.GetDirectoryName(lastNameBeforeRename) + "\\" + newName + Path.GetExtension(lastNameBeforeRename);
                int i = 0;

                if (!isDirectory(lastNameBeforeRename))
                    while (File.Exists(newPath))
                        newPath = Path.GetDirectoryName(lastNameBeforeRename) + "\\" + Path.GetFileNameWithoutExtension(newPath) + "(" + i++ + ")" + Path.GetExtension(newPath);
                else
                    while (Directory.Exists(newPath))
                        newPath = newPath + "(" + i++ + ")";


                if (isDirectory(lastNameBeforeRename))
                    Directory.Move(lastNameBeforeRename, newPath);
                else
                    File.Move(lastNameBeforeRename, newPath);
                dvg[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                dvg.BeginEdit(false);
                dvg.CancelEdit();
                pc.fillGrid();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
