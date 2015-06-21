using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class LoginForm : Form
    {
        HomePageForm hpf;
        public LoginForm(HomePageForm hpf)
        {
            InitializeComponent();
            this.hpf = hpf;
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + hpf.getUsername();
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 10;

        }

        private void registerLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form registerForm = new RegisterForm(hpf);
            registerForm.Show();
            this.Close();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterForm(hpf);
            registerForm.Show();
            this.Close();
        }
    }
}
