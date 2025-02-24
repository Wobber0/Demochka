using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class passwordchange : Form
    {
        public passwordchange()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(passwordchange_FormClosing);
        }

        string oldP;
        string newP;
        string appP;
        private void ChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void approvalPasswordBox_TextChanged(object sender, EventArgs e)
        {
            appP = approvalPasswordBox.Text;
            if (newP != appP) { warningLbl.Text = "Введенный пароль не совпадает с новым!"; }
            else { warningLbl.Text = ""; }
        }

        private void NewPasswordBox_TextChanged(object sender, EventArgs e)
        {
            newP = NewPasswordBox.Text;
        }

        private void OldPasswordBox_TextChanged(object sender, EventArgs e)
        {
            oldP = OldPasswordBox.Text;
        }

        private void passwordchange_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
