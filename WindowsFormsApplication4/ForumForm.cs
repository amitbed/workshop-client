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
    public partial class ForumForm : Form
    {
        HomePageForm hpf;
        string title;
        List<string> subForums;
        public ForumForm(HomePageForm hpf, string title, List<string> subForums)
        {
            InitializeComponent();
            this.hpf = hpf;
            this.title = title;
            this.subForums = subForums;
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + hpf.getUsername();
            if (hpf.username != "guest")
            {
                loginToolStripMenuItem.Text = "logout";
            }

            SubForumLbl.Hide();
            SubForumNameLbl.Hide();
            moderatorsComboBox.Hide();
            addModeratorBtn.Hide();
            moderatorsLbl.Hide();
        }

        private void ForumForm_Load(object sender, EventArgs e)
        {
            ForumNameLbl.Text = title;
            foreach (string sf in subForums)
            {
                subForumsListBox.Items.Add(sf);
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://amit-pc:49417/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/ApiMember").Result;
                resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                List<string> response = resp.Content.ReadAsAsync<List<string>>().Result;

                if (response == null || response.Count == 0 || String.IsNullOrEmpty(response.ElementAt(0)))
                {
                    moderatorsComboBox.Text = "no members";
                }
                else
                {
                    foreach (string s in response)
                    {
                        moderatorsComboBox.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

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
                client.BaseAddress = new Uri("http://amit-pc:49417/");
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

        private void addSubForumBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void SubForumTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
