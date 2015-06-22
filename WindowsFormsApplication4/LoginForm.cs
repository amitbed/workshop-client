using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

            if (hpf.username != "guest")
            {
                loginToolStripMenuItem.Text = "Logout";
            }

            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 20;

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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            List<string> args = new List<string>();
            args.Add(username);
            args.Add(password);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49417/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage resp = client.PostAsJsonAsync("api/ApiLogin", args).Result;
                resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                bool result = resp.Content.ReadAsAsync<bool>().Result;

                hpf.setUsername(username);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
