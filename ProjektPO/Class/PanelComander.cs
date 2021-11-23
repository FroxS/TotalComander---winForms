using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        private string getLengthFile(Int64 bytes)
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);
            
        }

        public void fillGrid()
        {

            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            dgv.Rows.Clear();
            DataTable table = new DataTable();
            table.Columns.Add("name");
            table.Columns.Add("typ");
            table.Columns.Add("size");

            dgv.Rows.Add(Path.GetDirectoryName(sourceDirectory), null, "...");
            foreach (var di in this.getDirectory())
            {
                DirectoryInfo directory = new DirectoryInfo(di);
                DateTime dt = Directory.GetCreationTime(di);
                Icon fileIco = DefaultIcons.FolderLarge;
                dgv.Rows.Add(new object[] {
                    di,
                    fileIco,
                    directory.Name,
                    dt.ToString("dd'-'MM'-'yyyy")
                });
                Cursor.Current = Cursors.WaitCursor;
            }

            foreach (var fi in this.getFiles())
            {
                FileInfo file = new FileInfo(fi);
                DateTime dt = File.GetCreationTime(fi);
                Icon fileIco = SystemIcons.WinLogo;
                fileIco = Icon.ExtractAssociatedIcon(file.FullName);
                dgv.Rows.Add(new object[] {
                    fi,
                    Icon.ExtractAssociatedIcon(file.FullName),
                    file.Name,
                    dt.ToString("dd'-'MM'-'yyyy"),
                    getLengthFile(file.Length)
                }) ;
                Cursor.Current = Cursors.WaitCursor;
            }
            Cursor.Current = Cursors.Default;
        }


        public void go(string source)
        {
            if (!string.IsNullOrEmpty(source))
            {
                SourceDirectory = source;
            }
            fillGrid();
        }
    }
}
