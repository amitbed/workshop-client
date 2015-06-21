namespace WindowsFormsApplication4
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewAccountLbl = new System.Windows.Forms.Label();
            this.RegisterLbl = new System.Windows.Forms.Label();
            this.UsernameLbl = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.ConfimPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfimPasswordLbl = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.menuStrip1.Size = new System.Drawing.Size(794, 25);
            this.menuStrip1.TabIndex = 0;
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
            // CreateNewAccountLbl
            // 
            this.CreateNewAccountLbl.AutoSize = true;
            this.CreateNewAccountLbl.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewAccountLbl.Location = new System.Drawing.Point(316, 78);
            this.CreateNewAccountLbl.Name = "CreateNewAccountLbl";
            this.CreateNewAccountLbl.Size = new System.Drawing.Size(259, 42);
            this.CreateNewAccountLbl.TabIndex = 4;
            this.CreateNewAccountLbl.Text = "Create new account";
            // 
            // RegisterLbl
            // 
            this.RegisterLbl.AutoSize = true;
            this.RegisterLbl.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterLbl.Location = new System.Drawing.Point(81, 36);
            this.RegisterLbl.Name = "RegisterLbl";
            this.RegisterLbl.Size = new System.Drawing.Size(229, 84);
            this.RegisterLbl.TabIndex = 3;
            this.RegisterLbl.Text = "Register";
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.Location = new System.Drawing.Point(92, 143);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(67, 17);
            this.UsernameLbl.TabIndex = 5;
            this.UsernameLbl.Text = "Username";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(95, 163);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(215, 25);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(95, 239);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(215, 25);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Location = new System.Drawing.Point(92, 219);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(64, 17);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "Password";
            // 
            // ConfimPasswordTextBox
            // 
            this.ConfimPasswordTextBox.Location = new System.Drawing.Point(92, 323);
            this.ConfimPasswordTextBox.Name = "ConfimPasswordTextBox";
            this.ConfimPasswordTextBox.Size = new System.Drawing.Size(215, 25);
            this.ConfimPasswordTextBox.TabIndex = 10;
            // 
            // ConfimPasswordLbl
            // 
            this.ConfimPasswordLbl.AutoSize = true;
            this.ConfimPasswordLbl.Location = new System.Drawing.Point(92, 303);
            this.ConfimPasswordLbl.Name = "ConfimPasswordLbl";
            this.ConfimPasswordLbl.Size = new System.Drawing.Size(109, 17);
            this.ConfimPasswordLbl.TabIndex = 9;
            this.ConfimPasswordLbl.Text = "Confim Password";
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(231, 384);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 32);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 442);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ConfimPasswordTextBox);
            this.Controls.Add(this.ConfimPasswordLbl);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.PasswordLbl);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLbl);
            this.Controls.Add(this.CreateNewAccountLbl);
            this.Controls.Add(this.RegisterLbl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label CreateNewAccountLbl;
        private System.Windows.Forms.Label RegisterLbl;
        private System.Windows.Forms.Label UsernameLbl;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox ConfimPasswordTextBox;
        private System.Windows.Forms.Label ConfimPasswordLbl;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}