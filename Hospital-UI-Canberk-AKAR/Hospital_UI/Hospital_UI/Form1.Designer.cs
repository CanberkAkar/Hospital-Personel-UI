namespace Hospital_UI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelLogins = new System.Windows.Forms.Panel();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPsw = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPsw_Main = new System.Windows.Forms.Label();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtPassword_Main = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelPersonelSub = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnLogins = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelLogins.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelPersonelSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogins
            // 
            this.panelLogins.Controls.Add(this.btnUsers);
            this.panelLogins.Controls.Add(this.btnLogin);
            this.panelLogins.Controls.Add(this.lblPsw);
            this.panelLogins.Controls.Add(this.panel1);
            this.panelLogins.Controls.Add(this.txtPassword);
            this.panelLogins.Controls.Add(this.lblPsw_Main);
            this.panelLogins.Controls.Add(this.panelPassword);
            this.panelLogins.Controls.Add(this.txtPassword_Main);
            this.panelLogins.Controls.Add(this.lblName);
            this.panelLogins.Controls.Add(this.panelName);
            this.panelLogins.Controls.Add(this.txtName);
            this.panelLogins.Location = new System.Drawing.Point(366, 54);
            this.panelLogins.Name = "panelLogins";
            this.panelLogins.Size = new System.Drawing.Size(400, 383);
            this.panelLogins.TabIndex = 9;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Location = new System.Drawing.Point(98, 304);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(175, 42);
            this.btnUsers.TabIndex = 23;
            this.btnUsers.Text = "ÜYE OL";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(98, 304);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(175, 42);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "GİRİŞ YAP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPsw
            // 
            this.lblPsw.AutoSize = true;
            this.lblPsw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPsw.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.lblPsw.Location = new System.Drawing.Point(50, 190);
            this.lblPsw.Name = "lblPsw";
            this.lblPsw.Size = new System.Drawing.Size(106, 22);
            this.lblPsw.TabIndex = 21;
            this.lblPsw.Text = "Şifre Tekrar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.panel1.Location = new System.Drawing.Point(50, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 2);
            this.panel1.TabIndex = 20;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Rockwell", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.txtPassword.Location = new System.Drawing.Point(50, 215);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(300, 28);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPsw_Main
            // 
            this.lblPsw_Main.AutoSize = true;
            this.lblPsw_Main.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPsw_Main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPsw_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.lblPsw_Main.Location = new System.Drawing.Point(50, 107);
            this.lblPsw_Main.Name = "lblPsw_Main";
            this.lblPsw_Main.Size = new System.Drawing.Size(49, 22);
            this.lblPsw_Main.TabIndex = 18;
            this.lblPsw_Main.Text = "Şifre";
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.panelPassword.Location = new System.Drawing.Point(50, 164);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(300, 2);
            this.panelPassword.TabIndex = 17;
            // 
            // txtPassword_Main
            // 
            this.txtPassword_Main.BackColor = System.Drawing.Color.White;
            this.txtPassword_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword_Main.Font = new System.Drawing.Font("Rockwell", 14F);
            this.txtPassword_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.txtPassword_Main.Location = new System.Drawing.Point(50, 131);
            this.txtPassword_Main.Name = "txtPassword_Main";
            this.txtPassword_Main.Size = new System.Drawing.Size(300, 28);
            this.txtPassword_Main.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.lblName.Location = new System.Drawing.Point(50, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 22);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Kullanıcı Adı";
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.panelName.Location = new System.Drawing.Point(50, 75);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(300, 2);
            this.panelName.TabIndex = 14;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Rockwell", 14F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.txtName.Location = new System.Drawing.Point(50, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 28);
            this.txtName.TabIndex = 13;
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.panelSideMenu.Controls.Add(this.panelPersonelSub);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(311, 450);
            this.panelSideMenu.TabIndex = 8;
            // 
            // panelPersonelSub
            // 
            this.panelPersonelSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(97)))), ((int)(((byte)(246)))));
            this.panelPersonelSub.Controls.Add(this.btnExit);
            this.panelPersonelSub.Controls.Add(this.btnNewUser);
            this.panelPersonelSub.Controls.Add(this.btnLogins);
            this.panelPersonelSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPersonelSub.Location = new System.Drawing.Point(0, 217);
            this.panelPersonelSub.Name = "panelPersonelSub";
            this.panelPersonelSub.Size = new System.Drawing.Size(311, 147);
            this.panelPersonelSub.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(0, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(311, 45);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.White;
            this.btnNewUser.Location = new System.Drawing.Point(0, 45);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNewUser.Size = new System.Drawing.Size(311, 45);
            this.btnNewUser.TabIndex = 4;
            this.btnNewUser.Text = "YENİ KULLANICI EKLE";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnLogins
            // 
            this.btnLogins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogins.FlatAppearance.BorderSize = 0;
            this.btnLogins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogins.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogins.ForeColor = System.Drawing.Color.White;
            this.btnLogins.Location = new System.Drawing.Point(0, 0);
            this.btnLogins.Name = "btnLogins";
            this.btnLogins.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLogins.Size = new System.Drawing.Size(311, 45);
            this.btnLogins.TabIndex = 0;
            this.btnLogins.Text = "GİRİŞ YAP";
            this.btnLogins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogins.UseVisualStyleBackColor = true;
            this.btnLogins.Click += new System.EventHandler(this.btnLogins_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(311, 217);
            this.panelLogo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLogins);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelLogins.ResumeLayout(false);
            this.panelLogins.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelPersonelSub.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogins;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPsw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPsw_Main;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox txtPassword_Main;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelPersonelSub;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnLogins;
        private System.Windows.Forms.Panel panelLogo;
    }
}

