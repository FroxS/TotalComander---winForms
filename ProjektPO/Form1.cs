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

namespace ProjektPO
{
    public partial class Form1 : Form
    {
        //private string[] fileAndDirectory;
        private string[] file;
        //private string[] directory;
        UC_DataGrid userControl;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        private void LoadFile(string src = "")
        {
            try{
                if (string.IsNullOrEmpty(src))
                {
                    using (var fbd = new FolderBrowserDialog())
                    {
                        DialogResult result = fbd.ShowDialog();

                        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                        {
                            src = fbd.SelectedPath;
                        }
                    }
                }
                //fileAndDirectory[0] = Directory.GetDirectories(src);
                file = Directory.GetFiles(src, "*");
                tboxDirectory.Text = src;
                fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void fillGrid(ref DataGridView dgv, string[] files)
        {
            dgv.Rows.Clear();
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("typ");
            table.Columns.Add("size");

            foreach (var fi in files)
            {
                FileInfo file = new FileInfo(fi);
                dgv.Rows.Add(file.Name, file.Extension, file.Length, fi);
                Cursor.Current = Cursors.WaitCursor;
            }
            Cursor.Current = Cursors.Default;
        }

        private void fillGrid()
        {
            userControl.dataGridFIleLeft.Rows.Clear();
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("typ");
            table.Columns.Add("size");

            //foreach(var di in this.file)
            //{
            //    DirectoryInfo directory = new DirectoryInfo(di);
            //    userControl.dataGridFIleLeft.Rows.Add(directory.Name, directory.Extension);
            //    Cursor.Current = Cursors.WaitCursor;
            //}

            foreach (var fi in this.file)
            {
                FileInfo file = new FileInfo(fi);
                userControl.dataGridFIleLeft.Rows.Add(file.Name, file.Extension, file.Length,fi);
                Cursor.Current = Cursors.WaitCursor;
            }

            //for (int i = 0; i < files.Length; i++)
            //{
            //    FileInfo file = new FileInfo(files[i]);
            //    DirectoryInfo directory = new DirectoryInfo(this.directory[i]);
            //    //table.Rows.Add(file.Name, file.Extension,file.Length);
            //    userControl.dataGridFIleLeft.Rows.Add(file.Name, file.Extension, file.Length);
            //    userControl.dataGridFIleLeft.Rows.Add(directory.Name, directory.Extension);
            //    Cursor.Current = Cursors.WaitCursor;
            //}
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl = new UC_DataGrid();

            panelLeft.Controls.Add(userControl);
            userControl.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
         | AnchorStyles.Left) | AnchorStyles.Right)));
            userControl.Dock = DockStyle.Fill;


            if (Directory.Exists("C:\\"))
            {
                LoadFile("C:\\");
            }


            dataGrid1.Rows.Clear();
            dataGrid2.Rows.Clear();
            //test
            fillGrid(ref dataGrid1, Directory.GetFiles("C:\\!!!Projekty\\Test\\", "*"));
            fillGrid(ref dataGrid2, Directory.GetFiles("C:\\!!!Projekty\\Test\\", "*"));
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(files[0]);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panelRight.BackColor = Color.Red;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panelRight.BackColor = Color.BlueViolet;
        }

        private void dataGrid2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        private void dataGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = dataGrid1.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        private void dataGrid1_MouseDown(object sender, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = dataGrid1.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                valueFromMouseDown = dataGrid1.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
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

        private void dataGrid2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void dataGrid2_DragDrop(object sender, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = dataGrid2.PointToClient(new Point(e.X, e.Y));

            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                var hittest = dataGrid2.HitTest(clientPoint.X, clientPoint.Y);
                if (hittest.ColumnIndex != -1
                    && hittest.RowIndex != -1)
                    dataGrid2[hittest.ColumnIndex, hittest.RowIndex].Value = cellvalue;

            }
        }
    }
}
