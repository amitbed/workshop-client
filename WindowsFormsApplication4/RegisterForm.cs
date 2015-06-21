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
    public partial class RegisterForm : Form
    {

        HomePageForm hpf;
        public RegisterForm(HomePageForm hpf)
        {
            InitializeComponent();
            this.hpf = hpf;
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + hpf.getUsername();
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 10;
            ConfimPasswordTextBox.PasswordChar = '*';
            ConfimPasswordTextBox.MaxLength = 10;

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm(hpf);
            loginForm.Show();
            this.Close();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.ToString().Equals(ConfimPasswordTextBox.Text.ToString()))
            {
                hpf.setUsername(UsernameTextBox.Text.ToString());
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please re-enter your password");
                PasswordTextBox.Text = String.Empty;
                ConfimPasswordTextBox.Text = String.Empty;
            }
        }
    }
}
