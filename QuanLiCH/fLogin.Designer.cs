namespace QuanLiCH
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkShowpass = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.txtPassWord = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbldangnhaphethong = new System.Windows.Forms.Label();
            this.chksavepass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(354, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(354, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password:";
            // 
            // chkShowpass
            // 
            this.chkShowpass.AutoSize = true;
            this.chkShowpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkShowpass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkShowpass.ForeColor = System.Drawing.Color.Teal;
            this.chkShowpass.Location = new System.Drawing.Point(478, 260);
            this.chkShowpass.Name = "chkShowpass";
            this.chkShowpass.Size = new System.Drawing.Size(85, 21);
            this.chkShowpass.TabIndex = 3;
            this.chkShowpass.Text = "View Pass";
            this.chkShowpass.UseVisualStyleBackColor = true;
            this.chkShowpass.CheckedChanged += new System.EventHandler(this.chkShowpass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaShell;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Teal;
            this.btnLogin.Location = new System.Drawing.Point(479, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(479, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(216, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(479, 172);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter your user name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(223, 22);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter your user name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Click += new System.EventHandler(this.txtUserName_Click);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // txtPassWord
            // 
            // 
            // 
            // 
            this.txtPassWord.CustomButton.Image = null;
            this.txtPassWord.CustomButton.Location = new System.Drawing.Point(203, 2);
            this.txtPassWord.CustomButton.Name = "";
            this.txtPassWord.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtPassWord.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassWord.CustomButton.TabIndex = 1;
            this.txtPassWord.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassWord.CustomButton.UseSelectable = true;
            this.txtPassWord.CustomButton.Visible = false;
            this.txtPassWord.Lines = new string[0];
            this.txtPassWord.Location = new System.Drawing.Point(479, 215);
            this.txtPassWord.MaxLength = 32767;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '\0';
            this.txtPassWord.PromptText = "Enter your pass word";
            this.txtPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassWord.SelectedText = "";
            this.txtPassWord.SelectionLength = 0;
            this.txtPassWord.SelectionStart = 0;
            this.txtPassWord.ShortcutsEnabled = true;
            this.txtPassWord.Size = new System.Drawing.Size(223, 22);
            this.txtPassWord.TabIndex = 2;
            this.txtPassWord.UseSelectable = true;
            this.txtPassWord.WaterMark = "Enter your pass word";
            this.txtPassWord.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassWord.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassWord.Click += new System.EventHandler(this.txtPassWord_Click);
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QuanLiCH.Properties.Resources._1487086345_cross_815774;
            this.button1.Location = new System.Drawing.Point(784, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 21);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 244);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lbldangnhaphethong
            // 
            this.lbldangnhaphethong.AutoSize = true;
            this.lbldangnhaphethong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldangnhaphethong.Location = new System.Drawing.Point(445, 110);
            this.lbldangnhaphethong.Name = "lbldangnhaphethong";
            this.lbldangnhaphethong.Size = new System.Drawing.Size(190, 31);
            this.lbldangnhaphethong.TabIndex = 16;
            this.lbldangnhaphethong.Text = "Login System";
            this.lbldangnhaphethong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chksavepass
            // 
            this.chksavepass.AutoSize = true;
            this.chksavepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chksavepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chksavepass.ForeColor = System.Drawing.Color.Teal;
            this.chksavepass.Location = new System.Drawing.Point(581, 260);
            this.chksavepass.Name = "chksavepass";
            this.chksavepass.Size = new System.Drawing.Size(121, 21);
            this.chksavepass.TabIndex = 18;
            this.chksavepass.Text = "Remember Pass";
            this.chksavepass.UseVisualStyleBackColor = true;
            this.chksavepass.CheckedChanged += new System.EventHandler(this.chksavepass_CheckedChanged);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 517);
            this.Controls.Add(this.chksavepass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbldangnhaphethong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chkShowpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkShowpass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassWord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbldangnhaphethong;
        private System.Windows.Forms.CheckBox chksavepass;
    }
}