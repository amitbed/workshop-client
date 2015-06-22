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
        public List<string> admins = new List<string>();
        public string getUsername()
        {
            return username;
        }

        public void setUsername(string newUsername)
        {
            username = newUsername;
            usernameToolStripMenuItem.Text = "hello " + username;
            loginToolStripMenuItem.Text = "Logout";
        }

        public HomePageForm()
        {
            InitializeComponent();
            usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString() + username;
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

            adminsComboBox.Items.Add("nofarb");
            adminsComboBox.Items.Add("amitbed");
            adminsComboBox.Items.Add("sagiav");

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49417/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage resp = client.GetAsync("api/ApiForum").Result;
                resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                string response = resp.Content.ReadAsAsync<string>().Result;
                if (response == null || String.IsNullOrEmpty(response))
                {
                    ForumListBox.Items.Add("No Forums in the system");
                }
                else
                {
                    List<string> result = response.Split(' ').ToList();
                    foreach (string s in result)
                    {
                        ForumListBox.Items.Add(s);
                    }
                }

                HttpResponseMessage resp1 = client.GetAsync("api/ApiMember").Result;
                resp1.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                List<string> response1 = resp1.Content.ReadAsAsync<List<string>>().Result;

                if (response1 == null || response1.Count == 0 || String.IsNullOrEmpty(response1.ElementAt(0)))
                {
                    adminsComboBox.Text = "no members";
                }
                else
                {
                    foreach (string s in response1)
                    {
                        adminsComboBox.Items.Add(s);
                    }
                }

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
            if (loginToolStripMenuItem.Text.Equals("Login"))
            {
                Form loginForm = new LoginForm(this);
                loginForm.Show();
            }
            else
            {
                loginToolStripMenuItem.Text = "Login";
                setUsername("guest");
                usernameToolStripMenuItem.Text = usernameToolStripMenuItem.Text.ToString(); // + this.getUsername();
            }
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            string currAdmins = adminsComboBox.Text.ToString();
            admins.Add(currAdmins);
            adminsComboBox.Items.Remove(currAdmins);
            adminsComboBox.Text = String.Empty;
        }

        private void addnewforumBtn_Click(object sender, EventArgs e)
        {
            var ForumName = ForumNameTextBox.Text;
            ForumListBox.Items.Remove("No Forums in the system");
            ForumListBox.Items.Add(ForumName);

            admins.Add(username);
            admins.Add(ForumName);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:49417/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                HttpResponseMessage resp = client.PostAsJsonAsync("api/ApiForum", admins).Result;//.Result; //PostAsJsonAsync("api/ApiForum").Result;
                resp.EnsureSuccessStatusCode();  // Throw exception if not a success code.
                string response = resp.Content.ReadAsAsync<string>().Result;
                if (response == null || String.IsNullOrEmpty(response))
                {
                    ForumListBox.Items.Add("No Forums in the system");
                }
                else
                {
                    List<string> result = response.Split(' ').ToList();
                    foreach (string s in result)
                    {
                        ForumListBox.Items.Add(s);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
