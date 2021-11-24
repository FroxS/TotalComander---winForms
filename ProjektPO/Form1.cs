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

        public TotalComander()
        {
            try
            {
                InitializeComponent();

                leftPanelGrid = new gridView(ref tboxDirectoryLeft);
                rightPanelGrid = new gridView(ref tboxDirectoryRight);

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
    }
}
