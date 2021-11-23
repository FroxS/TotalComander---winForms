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
    public partial class WinGetName : Form
    {
        private string value;

        public string Value { get => value; set => this.value = value; }

        public WinGetName()
        {
            InitializeComponent();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            value = tboxName.Text;
            this.Close();
        }

        private void btnCommit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value = tboxName.Text;
                this.Close();
            }
        }

        private void WinGetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                value = tboxName.Text;
                this.Close();
            }
        }
    }
}
