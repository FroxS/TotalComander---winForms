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

namespace ProjektPO
{
    public partial class Form1 : Form
    {
        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        private PanelComander leftComander;
        private PanelComander rightComander;

        public Form1()
        {
            try
            {
                InitializeComponent();
                leftComander = new PanelComander(dataGridLeft, tboxDirectoryLeft);
                rightComander = new PanelComander(dataGridRight, tboxDirectoryRight);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd:" + ex.Message);
            }
            
        }

        private void btnLoadLeft_Click(object sender, EventArgs e)
        {
            LoadFile(leftComander);
        }

        private void btnLoadRight_Click(object sender, EventArgs e)
        {
            LoadFile(rightComander);
        }

        private void LoadFile(PanelComander pc)
        {
            string src = "";
            try{
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        src = fbd.SelectedPath;
                    }
                }
                pc.SourceDirectory = src;
                pc.fillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            leftComander.SourceDirectory = "C:\\";
            rightComander.SourceDirectory = "C:\\";
            leftComander.fillGrid();
            rightComander.fillGrid();
        }

        private void dataGridLeft_MouseDown(object sender, MouseEventArgs e)
        {
            gridMouseDown(leftComander, e);
        }

        private void dataGridRight_MouseDown(object sender, MouseEventArgs e)
        {
            gridMouseDown(rightComander, e);
        }

        private void dataGridLeft_MouseMove(object sender, MouseEventArgs e)
        {
            gridMouseMove(leftComander, e);
        }

        private void dataGridRight_MouseMove(object sender, MouseEventArgs e)
        {
            gridMouseMove(rightComander, e);
        }

        private void dataGridRight_DragEnter(object sender, DragEventArgs e)
        {
            gridDragEnter(e);
        }

        private void dataGridLeft_DragEnter(object sender, DragEventArgs e)
        {
            gridDragEnter(e);
        }

        private void dataGridRight_DragOver(object sender, DragEventArgs e)
        {
            gridDragOver(e);
        }

        private void dataGridLeft_DragOver(object sender, DragEventArgs e)
        {
            gridDragOver(e);
        }

        private void dataGridRight_DragDrop(object sender, DragEventArgs e)
        {
            gridDragDrop(rightComander, e);
            rightComander.fillGrid();
            leftComander.fillGrid();
        }

        private void dataGridLeft_DragDrop(object sender, DragEventArgs e)
        {
            gridDragDrop(leftComander, e);
            rightComander.fillGrid();
            leftComander.fillGrid();
        }

        //Grid from drop
        private void gridMouseMove(PanelComander pc, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                // If the mouse moves outside the rectangle, start the drag.
                if (dragBoxFromMouseDown != Rectangle.Empty && !dragBoxFromMouseDown.Contains(e.X, e.Y))
                {
                    // Proceed with the drag and drop, passing in the list item.                    
                    DragDropEffects dropEffect = pc.Dgv.DoDragDrop(valueFromMouseDown, DragDropEffects.Copy);
                }
            }
        }

        //Grid from drop
        private void gridMouseDown(PanelComander pc, MouseEventArgs e)
        {
            // Get the index of the item the mouse is below.
            var hittestInfo = pc.Dgv.HitTest(e.X, e.Y);

            if (hittestInfo.RowIndex != -1 && hittestInfo.ColumnIndex != -1)
            {
                //valueFromMouseDown = dataGrid1.Rows[hittestInfo.RowIndex].Cells[hittestInfo.ColumnIndex].Value;
                valueFromMouseDown = pc.Dgv.Rows[hittestInfo.RowIndex].Cells[0].Value;
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

        //Grid to drop
        private void gridDragEnter(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Grid to drop
        private void gridDragOver(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        //Grid to drop
        private void gridDragDrop(PanelComander pc, DragEventArgs e)
        {
            // The mouse locations are relative to the screen, so they must be 
            // converted to client coordinates.
            Point clientPoint = pc.Dgv.PointToClient(new Point(e.X, e.Y));

            // If the drag operation was a copy then add the row to the other control.
            if (e.Effect == DragDropEffects.Copy)
            {
                string cellvalue = e.Data.GetData(typeof(string)) as string;
                if (!(valueFromMouseDown is null))
                {
                    var hittest = pc.Dgv.HitTest(clientPoint.X, clientPoint.Y);
                    if (!(pc is null))
                    {
                        moveFile(cellvalue, pc.SourceDirectory);
                    }
                    else
                    {
                        if (hittest.ColumnIndex != -1 && hittest.RowIndex != -1)
                        {
                            moveFile(cellvalue, Path.GetDirectoryName(pc.Dgv[0, hittest.RowIndex].Value.ToString()));
                            //fillGrid(dataGridLeft);
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



        private void moveFile(string file,string directory)
        {
            try
            {
                //Check if file and directory exist
                if (!(File.Exists(file)) && !(Directory.Exists(directory)))
                    throw new FileNotFoundException("Podane pliki nie istnieją!");

                File.Move(file, directory +"\\"+ Path.GetFileName(file));

            }catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception)
            {
                MessageBox.Show("Błąd programu");
            }
            
        }

        private void dataGridLeft_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                string path;
                if (leftComander.Dgv[0, e.RowIndex].Value is null)
                    leftComander.fillGrid();
                else
                {
                    if (leftComander.Dgv[3, e.RowIndex].Value is null)
                    {
                        path = leftComander.Dgv[0, e.RowIndex].Value.ToString();
                        leftComander.go(path);
                    }
                }
            }
        }
    }
}
