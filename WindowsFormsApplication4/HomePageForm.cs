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
    public partial class HomePageForm : Form
    {
        public string username = "guest";

        public string getUsername()
        {
            return username;
        }

        public void setUsername(string newUsername)
        {
            username = newUsername;
            usernameToolStripMenuItem.Text = "hello " + username;
        }

        public HomePageForm()
        {
            InitializeComponent();
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + username;
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {
            //TODO: add the current Forums
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterForm(this);
            registerForm.Show();
            //this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form loginForm = new LoginForm(this);
            loginForm.Show();
        }
    }
}
