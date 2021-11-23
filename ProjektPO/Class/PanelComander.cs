using ProjektPO.Viev;
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

        private string getCoppyFile(string destfile)
        {
            while (File.Exists(destfile))
            {
                destfile = Path.GetDirectoryName(destfile) + "\\" + Path.GetFileNameWithoutExtension(destfile) + "-kopia" + Path.GetExtension(destfile);
            }
            return destfile;
        }


        private string getCoppyDirectory(string destfolder)
        {
            while (Directory.Exists(destfolder))
                destfolder = destfolder + "-kopia";
            return destfolder;
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


        public bool isTheSameSource(string source)
        {
            string file1 = string.Empty, file2 = string.Empty;

            file1 = Path.GetDirectoryName(source);


            FileAttributes attr = File.GetAttributes(this.SourceDirectory);
            if (!attr.HasFlag(FileAttributes.Directory))
                file2 = Path.GetDirectoryName(this.SourceDirectory);
            else
                file2 = this.SourceDirectory;


            if (file1 == file2)
                return true;
            else
                return false;
        }



        public void pasteFile(string file,string action, bool overwrite = true)
        {
            try
            {
                //coppy file
                string destfile = this.sourceDirectory + "\\" + Path.GetFileName(file);
                if (action == "copy")
                {
                    
                    if (File.Exists(destfile))
                    {
                        if (!overwrite)
                            destfile = getCoppyFile(destfile);
                    }

                    File.Copy(file, destfile, overwrite);

                }//move File
                else if (action == "move")
                {
                    if (File.Exists(destfile))
                    {
                        string x = string.Empty;
                        using (WinFileExecute settingsForm = new WinFileExecute("Plik"))
                        {
                            if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                x = settingsForm.Value;
                                if (x == "delete")
                                    File.Delete(destfile);
                                if (x == "copy")
                                    destfile = getCoppyFile(destfile);
                            }
                        }
                    }
                    File.Move(file, destfile);
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd programu");
            }
        }


        public void pasteDirectory(string file, string action)
        {
            try
            {

                //coppy directroy
                string destdirectory = this.sourceDirectory + "\\" + Path.GetFileName(file);
                if (action == "copy")
                {

                    if (Directory.Exists(destdirectory))
                    {
                        destdirectory = getCoppyDirectory(destdirectory);
                    }

                    Directory.CreateDirectory(destdirectory);

                    using (WinFolderExecute settingsForm = new WinFolderExecute())
                    {
                        if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (settingsForm.Value)
                            {
                                DirectoryInfo deep = new DirectoryInfo(file);
                                DirectoryInfo[] directories = deep.GetDirectories(".", System.IO.SearchOption.AllDirectories);
                                foreach (DirectoryInfo di in directories)
                                {
                                    //Tworzenie folderów
                                    string folderToCreate = di.FullName.Replace(file, destdirectory);
                                    Directory.CreateDirectory(folderToCreate);
                                    foreach (FileInfo fi in di.GetFiles())
                                    {
                                        //Tworzenie plików
                                        string fileToCreate = fi.FullName.Replace(file, destdirectory);
                                        File.Create(fileToCreate);
                                    }
                                }
                            }
                        }
                    }

                }//move directory
                else if (action == "move")
                {
                    if (Directory.Exists(destdirectory))
                    {
                        using (WinFileExecute settingsForm = new WinFileExecute("Folder"))
                        {
                            if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                            {
                                if (settingsForm.Value == "delete")
                                    Directory.Delete(destdirectory,true);
                                if (settingsForm.Value == "copy")
                                    destdirectory = getCoppyDirectory(destdirectory);

                            }
                        }

                    }

                    Directory.Move(file, destdirectory);

                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd programu" + e.Message);
            }
        }



        public void deleteFile(string file)
        {
            if (File.Exists(file))
                File.Delete(file);
        }

        public void deleteDirectory(string dir)
        {
            if (Directory.Exists(dir))
                Directory.Delete(dir,true);
        }

        public void createDirectory(string name)
        {
            string newDir = this.sourceDirectory + "\\" + name;
            if (Directory.Exists(newDir))
            {
                newDir = getCoppyDirectory(newDir);
            }
            Directory.CreateDirectory(newDir);
            
        }

        

        public void copyFile(string from, string to, bool overwrite)
        {
            try
            {
                string destFile = to + "\\" + Path.GetFileName(from);
                if (!overwrite)
                {
                    while (File.Exists(destFile))
                    {
                        destFile = to + "\\" + Path.GetFileNameWithoutExtension(destFile) + "-kopia" + Path.GetExtension(destFile);
                    }
                }

                File.Copy(from, destFile, overwrite);

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Błąd programu");
            }
        }
    }
}
