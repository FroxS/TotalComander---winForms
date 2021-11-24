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
        private TextBox tb;

        internal PanelComander Pc { get => pc; set => pc = value; }

        public gridView(ref TextBox tb)
        {         
            InitializeComponent();
            this.tb = tb;
            pc = new PanelComander(this.dataGrid, tb, "C:\\");
            pc.fillGrid();
        }     


        //Grid from drop
        private void dataGrid_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = dataGrid.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1 && hittestInfo.RowIndex != 0 && hittestInfo.ColumnIndex != 0)
            {
                //valueFromMouseDown = dataGrid1.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                valueFromMouseDown = dataGrid.Rows[hittestInfo.RowIndex].Cells[0].Value;
                if (valueFromMouseDown != null)
                {
                    // Remember the point where the mouse down occurred. 
                    // The DragSize indicates the size that the mouse can move 
                    // before a drag event should be started.                
                    Size dragSize = SystemInformation.DragSize;
                    // Create a rectangle using the DragSize, with the mouse position being
                    // at the center of the rectangle.
                    dragBoxFromMouseDown = new Rectangle(new Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize);
                }
            }
            else
                // Reset the rectangle if the mouse is not over an item in the ListBox.
                dragBoxFromMouseDown = Rectangle.Empty;
        }

        //Grid from drop
        private void dataGrid_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = this.dataGrid.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        //Grid to drop
        private void dataGrid_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGrid.PointToClient(new Point(e.X, e.Y));

            // If the drag operation was a copy then add the row to the other control.
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
                        path = pc.Dgv[0, e.RowIndex].Value.ToString();
                        pc.go(path);
                    }
                }
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
    }
}
