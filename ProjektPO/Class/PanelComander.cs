using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPO.Class
{
    class PanelComander
    {
        private DataGridView dgv;
        private string sourceDirectory;
        private TextBox textbox;

        public PanelComander(DataGridView dgv, TextBox textbox)
        {
            this.dgv = dgv ?? throw new ArgumentNullException(nameof(dgv));
            this.textbox = textbox ?? throw new ArgumentNullException(nameof(textbox));
        }

        public PanelComander(DataGridView dgv, TextBox textbox, string sourceDirectory)
        {
            this.dgv = dgv ?? throw new ArgumentNullException(nameof(dgv));
            this.textbox = textbox ?? throw new ArgumentNullException(nameof(textbox));

            if(string.IsNullOrEmpty(sourceDirectory) || !Directory.Exists(sourceDirectory))
                throw new ArgumentNullException(nameof(sourceDirectory));
            else
                this.sourceDirectory = sourceDirectory;
        }

        public DataGridView Dgv { get => dgv; set => dgv = value; }
        public string SourceDirectory
        {
            get{
                return this.sourceDirectory;
            }  
            set{
                if (string.IsNullOrEmpty(value) || !Directory.Exists(value.ToString())) throw new ArgumentException("Ścieżka katalaogu jest pusta albo nie istnieje");
                //if (string.IsNullOrEmpty(value)) throw new ArgumentException("Ścieżka katalaogu jest pusta albo nie istnieje");
                this.sourceDirectory = value;
                this.textbox.Text = value;
            }
        }
        public TextBox Textbox { get => textbox; set => textbox = value; }


        private string[] getFiles()
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            return Directory.GetFiles(SourceDirectory, "*");
        }

        private string[] getDirectory()
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            return Directory.GetDirectories(SourceDirectory);
        }

        public void fillGrid()
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            dgv.Rows.Clear();
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("typ");
            table.Columns.Add("size");

            foreach (var di in this.getDirectory())
            {
                DirectoryInfo directory = new DirectoryInfo(di);
                dgv.Rows.Add(di, directory.Name);
                Cursor.Current = Cursors.WaitCursor;
            }

            foreach (var fi in this.getFiles())
            {
                FileInfo file = new FileInfo(fi);
                dgv.Rows.Add(fi, file.Name, file.Length, file.Extension);
                Cursor.Current = Cursors.WaitCursor;
            }
            Cursor.Current = Cursors.Default;
        }
    }
}
