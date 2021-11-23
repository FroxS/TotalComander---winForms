using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektPO.Viev
{
    public partial class WinFolderExecute : Form
    {
        private bool value;

        string comunicat;

        public bool Value { get => value; set => this.value = value; }

        public WinFolderExecute()
        {
            InitializeComponent();

            labCom.Text = "Kopiować folder z zawartością";
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            value= true;
            Close();
        }

        private void btnCoppy_Click(object sender, EventArgs e)
        {
            value =false;
            Close();
        }



    }
}
