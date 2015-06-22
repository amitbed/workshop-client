namespace WindowsFormsApplication4
{
    partial class ForumForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForumForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForumNameLbl = new System.Windows.Forms.Label();
            this.subForumsListBox = new System.Windows.Forms.ListBox();
            this.SubForumLbl = new System.Windows.Forms.Label();
            this.SubForumNameLbl = new System.Windows.Forms.Label();
            this.SubForumTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addAdminBtn = new System.Windows.Forms.Button();
            this.moderatorsComboBox = new System.Windows.Forms.ComboBox();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(794, 29);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.registerToolStripMenuItem.Text = "Register";
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
            // ForumNameLbl
            // 
            this.ForumNameLbl.AutoSize = true;
            this.ForumNameLbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForumNameLbl.Location = new System.Drawing.Point(75, 37);
            this.ForumNameLbl.Name = "ForumNameLbl";
            this.ForumNameLbl.Size = new System.Drawing.Size(352, 84);
            this.ForumNameLbl.TabIndex = 4;
            this.ForumNameLbl.Text = "Forum Name";
            // 
            // subForumsListBox
            // 
            this.subForumsListBox.FormattingEnabled = true;
            this.subForumsListBox.ItemHeight = 17;
            this.subForumsListBox.Location = new System.Drawing.Point(89, 160);
            this.subForumsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subForumsListBox.Name = "subForumsListBox";
            this.subForumsListBox.Size = new System.Drawing.Size(237, 225);
            this.subForumsListBox.TabIndex = 5;
            // 
            // SubForumLbl
            // 
            this.SubForumLbl.AutoSize = true;
            this.SubForumLbl.Location = new System.Drawing.Point(86, 139);
            this.SubForumLbl.Name = "SubForumLbl";
            this.SubForumLbl.Size = new System.Drawing.Size(80, 17);
            this.SubForumLbl.TabIndex = 6;
            this.SubForumLbl.Text = "Sub Forums:";
            // 
            // SubForumNameLbl
            // 
            this.SubForumNameLbl.AutoSize = true;
            this.SubForumNameLbl.Location = new System.Drawing.Point(371, 139);
            this.SubForumNameLbl.Name = "SubForumNameLbl";
            this.SubForumNameLbl.Size = new System.Drawing.Size(110, 17);
            this.SubForumNameLbl.TabIndex = 7;
            this.SubForumNameLbl.Text = "Sub Forum Name";
            // 
            // SubForumTextBox
            // 
            this.SubForumTextBox.Location = new System.Drawing.Point(374, 160);
            this.SubForumTextBox.Name = "SubForumTextBox";
            this.SubForumTextBox.Size = new System.Drawing.Size(201, 25);
            this.SubForumTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Moderators";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(374, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "add Sub-Forum";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.Location = new System.Drawing.Point(374, 245);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(109, 25);
            this.addAdminBtn.TabIndex = 18;
            this.addAdminBtn.Text = "add moderator";
            this.addAdminBtn.UseVisualStyleBackColor = true;
            // 
            // moderatorsComboBox
            // 
            this.moderatorsComboBox.FormattingEnabled = true;
            this.moderatorsComboBox.Location = new System.Drawing.Point(374, 214);
            this.moderatorsComboBox.Name = "moderatorsComboBox";
            this.moderatorsComboBox.Size = new System.Drawing.Size(145, 25);
            this.moderatorsComboBox.TabIndex = 17;
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.addAdminBtn);
            this.Controls.Add(this.moderatorsComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubForumTextBox);
            this.Controls.Add(this.SubForumNameLbl);
            this.Controls.Add(this.SubForumLbl);
            this.Controls.Add(this.subForumsListBox);
            this.Controls.Add(this.ForumNameLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ForumForm";
            this.Text = "ForumForm";
            this.Load += new System.EventHandler(this.ForumForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label ForumNameLbl;
        private System.Windows.Forms.ListBox subForumsListBox;
        private System.Windows.Forms.Label SubForumLbl;
        private System.Windows.Forms.Label SubForumNameLbl;
        private System.Windows.Forms.TextBox SubForumTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.Button addAdminBtn;
        private System.Windows.Forms.ComboBox moderatorsComboBox;
    }
}