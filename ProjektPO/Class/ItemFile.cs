using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using ProjektPO.Viev;

namespace ProjektPO.Class
{
    class ItemFile : PanelItem
    {
        private string extension;
        private long length;
        public ItemFile(string path) : base(path)
        {
            this.extension = System.IO.Path.GetExtension(path);
            this.created = File.GetCreationTime(path);
            this.ico = SystemIcons.WinLogo;
            this.ico = Icon.ExtractAssociatedIcon(path);
            this.length = new FileInfo(path).Length;
        }
        public override void delete()
        {
            if (File.Exists(path))
                File.Delete(path);
        }

        private string getCoppy(string destfile)
        {
            while (File.Exists(destfile))
            {
                destfile = System.IO.Path.GetDirectoryName(destfile) + "\\" + System.IO.Path.GetFileNameWithoutExtension(destfile) + "-kopia" + System.IO.Path.GetExtension(destfile);
            }
            return destfile;
        }

        public string getLength()
        {
            string[] suffixes = { "Bytes", "KB", "MB", "GB", "TB", "PB" };

            int counter = 0;
            decimal number = (decimal)this.length;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n1}{1}", number, suffixes[counter]);

        }

        public override void move(string source)
        {
            //coppy file
            string destfile = source + "\\" + name;
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
                            destfile = getCoppy(destfile);
                    }
                }
            }
            File.Move(path, destfile);
        }

        public override void copy(string source, bool overwrite)
        {
            //coppy file
            string destfile = source + "\\" + name;
            if (File.Exists(destfile))
            {
                if (!overwrite)
                    destfile = getCoppy(destfile);
            }

            File.Copy(path, destfile, overwrite);

            
        }
    }
}
