using ProjektPO.Class;
using ProjektPO.Viev;
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
    public partial class TotalComander : Form
    {
        private gridView leftPanelGrid;
        private gridView rightPanelGrid;

        private object[] toPanelLeft;
        private object[] toPanelRight;

        public gridView LeftPanelGrid { get => leftPanelGrid; set => leftPanelGrid = value; }
        public gridView RightPanelGrid { get => rightPanelGrid; set => rightPanelGrid = value; }

        public TotalComander()
        {
            try
            {
                InitializeComponent();
                cmbLeftDrive.DataSource = Environment.GetLogicalDrives();
                cmbRightDrive.DataSource = Environment.GetLogicalDrives();
                toPanelLeft = new object[] {
                    labelLeftSource,
                    cmbLeftDrive,
                    tboxSearchLeft
                };
                toPanelRight = new object[] {
                    labelRightSource,
                    cmbRightDrive,
                    tboxSearchRight
                };
                    
                leftPanelGrid = new gridView(ref toPanelLeft);
                rightPanelGrid = new gridView(ref toPanelRight);

                //leftPanelGrid = new gridView(ref tboxDirectoryLeft,ref labelLeftSource);
                //rightPanelGrid = new gridView(ref tboxDirectoryRight, ref labelRightSource);

                panelLeftGrid.Controls.Add(leftPanelGrid);
                leftPanelGrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
             | AnchorStyles.Left) | AnchorStyles.Right)));
                leftPanelGrid.Dock = DockStyle.Fill;

                panelRightGrid.Controls.Add(rightPanelGrid);
                rightPanelGrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
             | AnchorStyles.Left) | AnchorStyles.Right)));
                rightPanelGrid.Dock = DockStyle.Fill;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd:" + ex.Message);
            }
            
        }

        private void btnLoadLeft_Click(object sender, EventArgs e)
        {
            LoadFile(leftPanelGrid.Pc);
        }

        private void btnLoadRight_Click(object sender, EventArgs e)
        {
            LoadFile(rightPanelGrid.Pc);
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
       
        public void refreshAllGrids()
        {
            leftPanelGrid.Pc.fillGrid();
            rightPanelGrid.Pc.fillGrid();
        }

        private void btnMoveOne_Click(object sender, EventArgs e)
        {
            if (leftPanelGrid.Pc.Dgv.SelectedRows.Count > 0)
            {
                //Z lewego do prawego
                string path = leftPanelGrid.Pc.Dgv.SelectedRows[0].Cells[0].Value.ToString();
                PanelItem item = leftPanelGrid.Pc.getItem(path);


                leftPanelGrid.Pc.pasteItem(item, rightPanelGrid.Pc.SourceDirectory);
                refreshAllGrids();

            }
            else //(rightPanelGrid.Pc.Dgv.SelectedRows.Count > 0)
            {
                //Z prawego do lewego
                string path = rightPanelGrid.Pc.Dgv.SelectedRows[0].Cells[0].Value.ToString();
                PanelItem item = rightPanelGrid.Pc.getItem(path);


                rightPanelGrid.Pc.pasteItem(item, leftPanelGrid.Pc.SourceDirectory);
                refreshAllGrids();
            }
        }

        private void TotalComander_MouseDown(object sender, MouseEventArgs e)
        {
            var left = leftPanelGrid.Pc.Dgv.HitTest(e.X, e.Y);
            var right = rightPanelGrid.Pc.Dgv.HitTest(e.X, e.Y);
            if (!(left is null))
            {
                rightPanelGrid.Pc.Dgv.ClearSelection();
            }
            else if (!(right is null))
            {
                leftPanelGrid.Pc.Dgv.ClearSelection();
            }
            else
            {

                rightPanelGrid.Pc.Dgv.ClearSelection();
            }
            //leftPanelGrid.Pc.Dgv[left.RowIndex,left.ColumnIndex].Selected
        }
    }
}
