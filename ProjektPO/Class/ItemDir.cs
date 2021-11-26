using ProjektPO.Viev;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO.Class
{
    class ItemDir : PanelItem
    {

        public ItemDir(string path): base(path)
        {
            this.ico = DefaultIcons.FolderLarge;

            if (!(string.IsNullOrEmpty(path)))
                this.created = Directory.GetCreationTime(path);
            else
                this.created = null;
        }

        public override void copy(string name, bool overwrite)
        {

            //Do dokończenia 
            //coppy directroy
            string destdirectory = name + "\\" + this.name;

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
                        DirectoryInfo deep = new DirectoryInfo(this.path);
                        DirectoryInfo[] directories = deep.GetDirectories(".", System.IO.SearchOption.AllDirectories);
                        foreach (DirectoryInfo di in directories)
                        {
                            //Tworzenie folderów
                            string folderToCreate = di.FullName.Replace(this.path, destdirectory);
                            Directory.CreateDirectory(folderToCreate);
                            foreach (FileInfo fi in di.GetFiles())
                            {
                                //Tworzenie plików
                                string fileToCreate = fi.FullName.Replace(this.path, destdirectory);
                                File.Create(fileToCreate);
                            }
                        }
                    }
                }
            }
        }

        public override void delete()
        {
            if (Directory.Exists(path))
                Directory.Delete(path, true);
        }

        public string getCoppyDirectory(string destfolder)
        {
            while (Directory.Exists(destfolder))
                destfolder = destfolder + "-kopia";
            return destfolder;
        }

        public override void move(string name)
        {
            //coppy directroy
            string destdirectory = name + "\\" + this.name;
            if (Directory.Exists(destdirectory))
            {
                using (WinFileExecute settingsForm = new WinFileExecute("Folder"))
                {
                    if (settingsForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (settingsForm.Value == "delete")
                            Directory.Delete(destdirectory, true);
                        if (settingsForm.Value == "copy")
                            destdirectory = getCoppyDirectory(destdirectory);

                    }
                }

            }
            Directory.Move(path, destdirectory);        
        }


    }
}
