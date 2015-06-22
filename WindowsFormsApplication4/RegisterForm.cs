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
    public partial class RegisterForm : Form
    {

        HomePageForm hpf;
        public RegisterForm(HomePageForm hpf)
        {
            InitializeComponent();
            this.hpf = hpf;
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + hpf.getUsername();

            if (hpf.username != "guest")
            {
                loginToolStripMenuItem.Text = "logout";
            }

            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.MaxLength = 10;
            ConfimPasswordTextBox.PasswordChar = '*';
            ConfimPasswordTextBox.MaxLength = 10;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginToolStripMenuItem.Text.Equals("Login"))
            {
                Form loginForm = new LoginForm(hpf);
                loginForm.Show();
                this.Close();
            }
            else
            {
                loginToolStripMenuItem.Text = "Login";
                hpf.setUsername("guest");
                usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + hpf.getUsername();
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text.ToString().Equals(ConfimPasswordTextBox.Text.ToString()))
            {
                hpf.setUsername(UsernameTextBox.Text.ToString());

                List<string> args = new List<string>();
                args.Add(UsernameTextBox.Text.ToString());
                args.Add(PasswordTextBox.Text.ToString());

                //HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("http://localhost:49417/");
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //try
                //{
                //    HttpResponseMessage resp = client.PostAsJsonAsync("api/ApiRegister", args).Result;//.Result; //PostAsJsonAsync("api/ApiForum").Result;
                //    resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                //    string response = resp.Content.ReadAsAsync<string>().Result;
                    this.Close();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error: " + ex);
                //}
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
