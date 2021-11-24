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
    public partial class WinFileExecute : Form
    {
        private string value;

        public string Value { get => value; set => this.value = value; }

        public WinFileExecute(string com)
        {
            InitializeComponent();

            labCom.Text = com + " istnieje, przenieśc plik czy stworzyć nowy?";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            value= "delete";
            Close();
        }

        private void btnCoppy_Click(object sender, EventArgs e)
        {
            value ="copy";
            Close();
        }

    }
}
