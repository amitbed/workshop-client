namespace WindowsFormsApplication4
{
    partial class LoginForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HomePageLbl = new System.Windows.Forms.Label();
            this.OurForumApplicationLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginCheckBox = new System.Windows.Forms.CheckBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.registerLinkLbl = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(794, 27);
            this.menuStrip1.TabIndex = 1;
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
            // 
            // HomePageLbl
            // 
            this.HomePageLbl.AutoSize = true;
            this.HomePageLbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePageLbl.Location = new System.Drawing.Point(74, 27);
            this.HomePageLbl.Name = "HomePageLbl";
            this.HomePageLbl.Size = new System.Drawing.Size(185, 84);
            this.HomePageLbl.TabIndex = 3;
            this.HomePageLbl.Text = "Log in";
            // 
            // OurForumApplicationLbl
            // 
            this.OurForumApplicationLbl.AutoSize = true;
            this.OurForumApplicationLbl.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OurForumApplicationLbl.Location = new System.Drawing.Point(81, 111);
            this.OurForumApplicationLbl.Name = "OurForumApplicationLbl";
            this.OurForumApplicationLbl.Size = new System.Drawing.Size(350, 42);
            this.OurForumApplicationLbl.TabIndex = 4;
            this.OurForumApplicationLbl.Text = "use a local account to login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(88, 189);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(168, 25);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(88, 268);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(168, 25);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 248);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "password";
            // 
            // loginCheckBox
            // 
            this.loginCheckBox.AutoSize = true;
            this.loginCheckBox.Location = new System.Drawing.Point(88, 299);
            this.loginCheckBox.Name = "loginCheckBox";
            this.loginCheckBox.Size = new System.Drawing.Size(116, 21);
            this.loginCheckBox.TabIndex = 9;
            this.loginCheckBox.Text = "remember me?";
            this.loginCheckBox.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(88, 343);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 31);
            this.LoginBtn.TabIndex = 10;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            // 
            // registerLinkLbl
            // 
            this.registerLinkLbl.AutoSize = true;
            this.registerLinkLbl.Location = new System.Drawing.Point(88, 395);
            this.registerLinkLbl.Name = "registerLinkLbl";
            this.registerLinkLbl.Size = new System.Drawing.Size(224, 17);
            this.registerLinkLbl.TabIndex = 11;
            this.registerLinkLbl.TabStop = true;
            this.registerLinkLbl.Text = "Register if you don\'t have an account";
            this.registerLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLbl_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.registerLinkLbl);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.loginCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OurForumApplicationLbl);
            this.Controls.Add(this.HomePageLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
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
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox loginCheckBox;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.LinkLabel registerLinkLbl;
    }
}