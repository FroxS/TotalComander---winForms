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
        private string[] files;
        UC_DataGrid userControl;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    files = Directory.GetFiles(fbd.SelectedPath);
                    tboxDirectory.Text = fbd.SelectedPath;
                    fillGrid();
                }
            }
        }

        private void fillGrid()
        {
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("typ");
            table.Columns.Add("size");
            

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                //table.Rows.Add(file.Name, file.Extension,file.Length);
                userControl.dataGridFIleLeft.Rows.Add(file.Name, file.Extension, file.Length);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl = new UC_DataGrid();

            panelLeft.Controls.Add(userControl);
            userControl.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
         | AnchorStyles.Left) | AnchorStyles.Right)));
            userControl.Dock = DockStyle.Fill;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            MessageBox.Show(files[0]);
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            panel1.BackColor = Color.Red;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.BlueViolet;
        }
    }
}
