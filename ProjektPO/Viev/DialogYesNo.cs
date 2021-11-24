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
    public partial class DialogYesNo : Form
    {
        private bool value;

        public bool Value { get => value; set => this.value = value; }

        public DialogYesNo(string text)
        {
            InitializeComponent();
            labText.Text = text;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            value = true;
            Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            value = false;
            Close();
        }
    }
}
