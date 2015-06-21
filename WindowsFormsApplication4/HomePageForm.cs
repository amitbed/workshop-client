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
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49417/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/Values").Result;
                listBox1.Text = "";
                resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                if (resp.Content == null)
                {
                    listBox1.Text = "No Forums in the system";
                }
                else
                {
                    //    listBox1.Text = resp.Content
                }


                label1.Text = resp.Content.ReadAsAsync<IEnumerable<string>>().Result.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
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
