using ProjektPO.Viev;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPO.Class
{
    class PanelComander
    {
        private DataGridView dgv;
        private string sourceDirectory;
        private List<PanelItem> item = new List<PanelItem>();
        private bool goBack = false;


        public PanelComander(DataGridView dgv)
        {
            this.dgv = dgv ?? throw new ArgumentNullException(nameof(dgv));
            fillItem();
        }

        public PanelComander(DataGridView dgv, string sourceDirectory)
        {
            this.dgv = dgv ?? throw new ArgumentNullException(nameof(dgv));

            if(string.IsNullOrEmpty(sourceDirectory) || !Directory.Exists(sourceDirectory))
                throw new ArgumentNullException(nameof(sourceDirectory));
            else
                this.sourceDirectory = sourceDirectory;

            fillItem();
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
            }
        }
        public bool GoBack { get => goBack; set => goBack = value; }

        private void fillItem(string search = "")
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");

            item = item is null ? item = new List<PanelItem>():item;

            ItemDir root = new ItemDir(System.IO.Path.GetDirectoryName(sourceDirectory));
            root.Name = "...";
            item.Add(root);

            if (!string.IsNullOrEmpty(search))
                search = "*" + search + "*";
            else
                search = "*";

            foreach (DirectoryInfo directory in new DirectoryInfo(sourceDirectory).GetDirectories(search))
            {

                item.Add(new ItemDir(directory.FullName));
                
            }
            foreach (FileInfo files in new DirectoryInfo(sourceDirectory).GetFiles(search))
            {
                item.Add(new ItemFile(files.FullName));
            }
            dgv.ClearSelection();
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


        public void fillGrid(bool refresh = false)
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            dgv.Rows.Clear();

            if (!(item[0].Path == SourceDirectory)|| goBack || refresh) 
            {
                goBack = false;
                item = null;
                fillItem();
            } 
            foreach (PanelItem pi in item)
            {
                dgv.Rows.Add(new object[] {
                    pi.Path,
                    pi.Ico,
                    pi.Name,
                    pi.Created?.ToString("dd'-'MM'-'yyyy"),
                    (pi as ItemFile) is null ? null :(pi as ItemFile).getLength()
                }); ; ;
                Cursor.Current = Cursors.WaitCursor;
            }
            Cursor.Current = Cursors.Default;
        }

        public void fillGrid(string search)
        {
            if (string.IsNullOrEmpty(SourceDirectory)) throw new ArgumentException("Katalog panelu nie został utworozny");
            dgv.Rows.Clear();

            item = null;
            fillItem(search);

            foreach (PanelItem pi in item)
            {
                dgv.Rows.Add(new object[] {
                    pi.Path,
                    pi.Ico,
                    pi.Name,
                    pi.Created?.ToString("dd'-'MM'-'yyyy"),
                    (pi as ItemFile) is null ? null :(pi as ItemFile).getLength()
                }); ; ;
                Cursor.Current = Cursors.WaitCursor;
            }
            Cursor.Current = Cursors.Default;
        }

        public void go(string source)
        {
            if (HasFolderWritePermission(source))
            {
                if (!string.IsNullOrEmpty(source))
                {
                    SourceDirectory = source;
                }
                fillGrid();
            }
            else
            {
                MessageBox.Show("Brak uprawniń do tego folderu");
            }
            
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

        public PanelItem getItem(string path)
        {
            foreach (PanelItem pi in item)
            {
                if (pi.Path == path)
                    return pi;
            }
            return null;
        }

        public List<PanelItem> getItems(string[] path)
        {
            List<PanelItem> x = new List<PanelItem>();
            foreach (PanelItem pi in item)
            {
                foreach(string s in path)
                {
                    if (pi.Path == s)
                        x.Add(pi);
                }
                
            }
            if (x.Count == 0) return null;
            return x;
        }

        public void pasteItem(PanelItem item,string source)
        {
            item.move(source);
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

                                File.Move(file, destfile);
                            }
                        }
                    }
                    
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
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

                                Directory.Move(file, destdirectory);

                            }
                        }

                    }

                    

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

        private bool HasFolderWritePermission(string destDir)
        {
            if (string.IsNullOrEmpty(destDir) || !Directory.Exists(destDir)) return false;
            try
            {
                new DirectoryInfo(destDir).GetDirectories();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
