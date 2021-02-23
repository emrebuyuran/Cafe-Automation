namespace CafeOtomasyon
{
    partial class frmSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignIn));
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxCaptcha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshCaptcha = new System.Windows.Forms.Button();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.btnLogo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxUser
            // 
            this.cbxUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUser.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Location = new System.Drawing.Point(441, 86);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(254, 31);
            this.cbxUser.TabIndex = 0;
            this.cbxUser.SelectedIndexChanged += new System.EventHandler(this.cbxUser_SelectedIndexChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.tbxPassword.Location = new System.Drawing.Point(441, 137);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(254, 32);
            this.tbxPassword.TabIndex = 1;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignIn.Image = ((System.Drawing.Image)(resources.GetObject("btnSignIn.Image")));
            this.btnSignIn.Location = new System.Drawing.Point(452, 306);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(182, 59);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::CafeOtomasyon.Properties.Resources.cikis;
            this.btnExit.Location = new System.Drawing.Point(640, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(66, 59);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // tbxCaptcha
            // 
            this.tbxCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxCaptcha.Location = new System.Drawing.Point(492, 235);
            this.tbxCaptcha.Name = "tbxCaptcha";
            this.tbxCaptcha.Size = new System.Drawing.Size(156, 29);
            this.tbxCaptcha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(377, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Captcha :";
            // 
            // btnRefreshCaptcha
            // 
            this.btnRefreshCaptcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshCaptcha.ForeColor = System.Drawing.Color.Crimson;
            this.btnRefreshCaptcha.Image = global::CafeOtomasyon.Properties.Resources.refresh;
            this.btnRefreshCaptcha.Location = new System.Drawing.Point(664, 235);
            this.btnRefreshCaptcha.Name = "btnRefreshCaptcha";
            this.btnRefreshCaptcha.Size = new System.Drawing.Size(31, 29);
            this.btnRefreshCaptcha.TabIndex = 3;
            this.btnRefreshCaptcha.UseVisualStyleBackColor = true;
            this.btnRefreshCaptcha.Click += new System.EventHandler(this.btnRefreshCaptcha_Click);
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.BackColor = System.Drawing.Color.White;
            this.lblCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCaptcha.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblCaptcha.Location = new System.Drawing.Point(519, 182);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(0, 39);
            this.lblCaptcha.TabIndex = 9;
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.White;
            this.btnLogo.Image = global::CafeOtomasyon.Properties.Resources.restlogo;
            this.btnLogo.Location = new System.Drawing.Point(32, 106);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(231, 170);
            this.btnLogo.TabIndex = 10;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // frmSignIn
            // 
            this.AcceptButton = this.btnSignIn;
            this.AccessibleName = "";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CafeOtomasyon.Properties.Resources.backgroundblack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 426);
            this.Controls.Add(this.btnLogo);
            this.Controls.Add(this.lblCaptcha);
            this.Controls.Add(this.btnRefreshCaptcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxCaptcha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.cbxUser);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetkili Girişi";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCaptcha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefreshCaptcha;
        private System.Windows.Forms.Label lblCaptcha;
        private System.Windows.Forms.Button btnLogo;
    }
}

