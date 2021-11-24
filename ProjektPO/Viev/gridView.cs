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

        private Rectangle dragBoxFromMouseDown;
        private object valueFromMouseDown;

        public gridView()
        {
            InitializeComponent();
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

                    if (hittest.RowIndex != -1 && hittest.ColumnIndex != -1)
                    {
                        MessageBox.Show("From: " + cellvalue + " to: " + dataGrid[hittest.RowIndex, hittest.ColumnIndex].Value.ToString());
                    }

                    //if (!(pc is null) && hittest.RowIndex != -1 && hittest.ColumnIndex != -1)
                    //{

                    //    if (!pc.isTheSameSource(cellvalue))
                    //    {

                    //        if (!isDirectory(cellvalue))
                    //        {
                    //            if (chboxMove.Checked)
                    //                pc.pasteFile(cellvalue, "move");
                    //            else
                    //                pc.pasteFile(cellvalue, "copy", chboxOverwrite.Checked);
                    //        }
                    //        else
                    //        {
                    //            if (chboxMove.Checked)
                    //                pc.pasteDirectory(cellvalue, "move");
                    //            else
                    //                pc.pasteDirectory(cellvalue, "copy");
                    //        }
                    //    }

                    //}


                }
                else
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    if (!(files is null))
                        MessageBox.Show(files[0]);
                }


            }
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
    }
}
