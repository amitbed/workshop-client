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
    public partial class SubForumForm : Form
    {

        HomePageForm hpf;
        public SubForumForm(HomePageForm hpf)
        {
            InitializeComponent();
            this.hpf = hpf;
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

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:49417/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                try
                {
                    HttpResponseMessage resp = client.PostAsJsonAsync("api/ApiLogin", hpf.getUsername()).Result;
                    resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                    bool response = resp.Content.ReadAsAsync<bool>().Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void SubForumForm_Load(object sender, EventArgs e)
        {

        }
    }
}
