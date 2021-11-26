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

                panelLeftGrid.Controls.Add(leftPanelGrid);
                leftPanelGrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
             | AnchorStyles.Left) | AnchorStyles.Right)));
                leftPanelGrid.Dock = DockStyle.Fill;

                panelRightGrid.Controls.Add(rightPanelGrid);
                rightPanelGrid.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
             | AnchorStyles.Left) | AnchorStyles.Right)));
                rightPanelGrid.Dock = DockStyle.Fill;


                labDescription.Text = "F7 -> tworzy nowy plik, F8,Del -> Usuwa zaznaczyony plik";
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


        //Przenoszenie zaznaczonych plików
        private void btnMoveOne_Click(object sender, EventArgs e)
        {
            moveFiles();
        }


        private bool YesOrNot(string text = "")
        {
            using (DialogYesNo settingsForm = new DialogYesNo(text))
            {
                if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (settingsForm.Value)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }


        //Wyczyszenie zaznaczenia elementów
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



        private void moveFiles()
        {

            if (leftPanelGrid.Pc.Dgv.SelectedRows.Count > 0)
            {
                //Z lewego do prawego
                string[] path = leftPanelGrid.Pc.Dgv.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Cells[0].Value.ToString().Trim()).ToArray();
                        
                List<PanelItem> items = leftPanelGrid.Pc.getItems(path);
                if (YesOrNot("Czy jesteś pewien że chcesz przenieść plik do folderu " + Path.GetFileName(rightPanelGrid.Pc.SourceDirectory + "?")))
                {
                    foreach (PanelItem item in items)
                        leftPanelGrid.Pc.pasteItem(item, rightPanelGrid.Pc.SourceDirectory);
                    refreshAllGrids();
                }

            }
            else //(rightPanelGrid.Pc.Dgv.SelectedRows.Count > 0)
            {
                //Z prawego do lewego

                string[] path = rightPanelGrid.Pc.Dgv.SelectedRows.Cast<DataGridViewRow>().Select(x => x.Cells[0].Value.ToString().Trim()).ToArray();

                List<PanelItem> items = rightPanelGrid.Pc.getItems(path);
                if (YesOrNot("Czy jesteś pewien że chcesz przenieść pliki do folderu " + Path.GetFileName(leftPanelGrid.Pc.SourceDirectory + "?")))
                {
                    foreach (PanelItem item in items)
                        rightPanelGrid.Pc.pasteItem(item, leftPanelGrid.Pc.SourceDirectory);
                    refreshAllGrids();
                }

            }
        }
    }
}
