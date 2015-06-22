namespace WindowsFormsApplication4
{
    partial class HomePageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageLbl = new System.Windows.Forms.Label();
            this.OurForumApplicationLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ForumListBox = new System.Windows.Forms.ListBox();
            this.addnewforumBtn = new System.Windows.Forms.Button();
            this.AdminsLbl = new System.Windows.Forms.Label();
            this.ForumNameTextBox = new System.Windows.Forms.TextBox();
            this.enterForumNameLbl = new System.Windows.Forms.Label();
            this.adminsComboBox = new System.Windows.Forms.ComboBox();
            this.addAdminBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem,
            this.usernameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(794, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usernameToolStripMenuItem.Image")));
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.usernameToolStripMenuItem.Text = "hello ";
            // 
            // HomePageLbl
            // 
            this.HomePageLbl.AutoSize = true;
            this.HomePageLbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLbl.Location = new System.Drawing.Point(73, 35);
            this.HomePageLbl.Name = "HomePageLbl";
            this.HomePageLbl.Size = new System.Drawing.Size(309, 84);
            this.HomePageLbl.TabIndex = 1;
            this.HomePageLbl.Text = "Home Page";
            // 
            // OurForumApplicationLbl
            // 
            this.OurForumApplicationLbl.AutoSize = true;
            this.OurForumApplicationLbl.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurForumApplicationLbl.Location = new System.Drawing.Point(399, 77);
            this.OurForumApplicationLbl.Name = "OurForumApplicationLbl";
            this.OurForumApplicationLbl.Size = new System.Drawing.Size(303, 42);
            this.OurForumApplicationLbl.TabIndex = 2;
            this.OurForumApplicationLbl.Text = "Our Forum Application";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Forums";
            // 
            // ForumListBox
            // 
            this.ForumListBox.FormattingEnabled = true;
            this.ForumListBox.ItemHeight = 17;
            this.ForumListBox.Location = new System.Drawing.Point(86, 144);
            this.ForumListBox.Name = "ForumListBox";
            this.ForumListBox.Size = new System.Drawing.Size(296, 191);
            this.ForumListBox.TabIndex = 9;
            this.ForumListBox.SelectedIndexChanged += new System.EventHandler(this.ForumListBox_SelectedIndexChanged);
            // 
            // addnewforumBtn
            // 
            this.addnewforumBtn.Location = new System.Drawing.Point(600, 291);
            this.addnewforumBtn.Name = "addnewforumBtn";
            this.addnewforumBtn.Size = new System.Drawing.Size(75, 44);
            this.addnewforumBtn.TabIndex = 14;
            this.addnewforumBtn.Text = "add new forum";
            this.addnewforumBtn.UseVisualStyleBackColor = true;
            this.addnewforumBtn.Click += new System.EventHandler(this.addnewforumBtn_Click);
            // 
            // AdminsLbl
            // 
            this.AdminsLbl.AutoSize = true;
            this.AdminsLbl.Location = new System.Drawing.Point(403, 191);
            this.AdminsLbl.Name = "AdminsLbl";
            this.AdminsLbl.Size = new System.Drawing.Size(99, 17);
            this.AdminsLbl.TabIndex = 12;
            this.AdminsLbl.Text = "Choose Admins";
            // 
            // ForumNameTextBox
            // 
            this.ForumNameTextBox.Location = new System.Drawing.Point(405, 150);
            this.ForumNameTextBox.Name = "ForumNameTextBox";
            this.ForumNameTextBox.Size = new System.Drawing.Size(270, 25);
            this.ForumNameTextBox.TabIndex = 11;
            // 
            // enterForumNameLbl
            // 
            this.enterForumNameLbl.AutoSize = true;
            this.enterForumNameLbl.Location = new System.Drawing.Point(402, 130);
            this.enterForumNameLbl.Name = "enterForumNameLbl";
            this.enterForumNameLbl.Size = new System.Drawing.Size(107, 17);
            this.enterForumNameLbl.TabIndex = 10;
            this.enterForumNameLbl.Text = "Enter Forum Title";
            // 
            // adminsComboBox
            // 
            this.adminsComboBox.FormattingEnabled = true;
            this.adminsComboBox.Location = new System.Drawing.Point(406, 211);
            this.adminsComboBox.Name = "adminsComboBox";
            this.adminsComboBox.Size = new System.Drawing.Size(145, 25);
            this.adminsComboBox.TabIndex = 15;
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.Location = new System.Drawing.Point(567, 211);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(109, 25);
            this.addAdminBtn.TabIndex = 16;
            this.addAdminBtn.Text = "add admin";
            this.addAdminBtn.UseVisualStyleBackColor = true;
            this.addAdminBtn.Click += new System.EventHandler(this.addAdminBtn_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.addAdminBtn);
            this.Controls.Add(this.adminsComboBox);
            this.Controls.Add(this.addnewforumBtn);
            this.Controls.Add(this.AdminsLbl);
            this.Controls.Add(this.ForumNameTextBox);
            this.Controls.Add(this.enterForumNameLbl);
            this.Controls.Add(this.ForumListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OurForumApplicationLbl);
            this.Controls.Add(this.HomePageLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.Load += new System.EventHandler(this.HomePageForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label HomePageLbl;
        private System.Windows.Forms.Label OurForumApplicationLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ForumListBox;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.Button addnewforumBtn;
        private System.Windows.Forms.Label AdminsLbl;
        private System.Windows.Forms.TextBox ForumNameTextBox;
        private System.Windows.Forms.Label enterForumNameLbl;
        private System.Windows.Forms.ComboBox adminsComboBox;
        private System.Windows.Forms.Button addAdminBtn;
    }
}