using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public partial class WinformPromptDialog : Form
    {
        public string MyKey { get; set; }

        public WinformPromptDialog(string nasaKey)
        {
            InitializeComponent();

            if (nasaKey != string.Empty)
            {
                labTitle.Text = "Blah blah";
                txtMyKey.Text = MyKey;
                btnInsertKey.Text = "Confirm";
            }
            else
            {
                labTitle.Text = "Blah blah";
                txtMyKey.Text = string.Empty;
                btnInsertKey.Text = "Insert";
            }
        }

        private void btnInsertKey_Click(object sender, EventArgs e)
        {
            MyKey = txtMyKey.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtMyKey_TextChanged(object sender, EventArgs e)
        {
            labTitle.Text = "Blah blah";
            btnInsertKey.Text = "Insert";
        }
    }
}
