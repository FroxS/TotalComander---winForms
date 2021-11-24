using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektPO.Class
{
    abstract class PanelItem
    {
        protected string name;
        protected string path;
        protected DateTime created;
        protected Icon ico;

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public DateTime Created { get => created; set => created = value; }
        public Icon Ico { get => ico; set => ico = value; }

        protected PanelItem(string path)
        {
            this.path = path;
            this.name = System.IO.Path.GetFileName(path);
        }

        protected bool isFile()
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
                return false;
            else
                return true;
        }

        protected bool isDirectory()
        {
            FileAttributes attr = File.GetAttributes(path);
            if (attr.HasFlag(FileAttributes.Directory))
                return true;
            else
                return false;
        }

        abstract public void delete();

        abstract public void move(string name);

        abstract public void copy(string name, bool overwrite);

    }
}
