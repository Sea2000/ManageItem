namespace QuanLiCH
{
    partial class frmAdminAccount
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
            this.dtgAccount = new System.Windows.Forms.DataGridView();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnWiewAccout = new System.Windows.Forms.Button();
            this.btnEditAccout = new System.Windows.Forms.Button();
            this.btnDeleteAccout = new System.Windows.Forms.Button();
            this.btnAddAccout = new System.Windows.Forms.Button();
            this.pnAccountMenu = new System.Windows.Forms.Panel();
            this.btnreEnterPass = new System.Windows.Forms.Button();
            this.panel28 = new System.Windows.Forms.Panel();
            this.nmTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.panel27 = new System.Windows.Forms.Panel();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbIdAccout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.panel21.SuspendLayout();
            this.pnAccountMenu.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAccount
            // 
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(12, 97);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.Size = new System.Drawing.Size(426, 341);
            this.dtgAccount.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnWiewAccout);
            this.panel21.Controls.Add(this.btnEditAccout);
            this.panel21.Controls.Add(this.btnDeleteAccout);
            this.panel21.Controls.Add(this.btnAddAccout);
            this.panel21.Location = new System.Drawing.Point(12, 21);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(427, 49);
            this.panel21.TabIndex = 3;
            // 
            // btnWiewAccout
            // 
            this.btnWiewAccout.Location = new System.Drawing.Point(330, -4);
            this.btnWiewAccout.Name = "btnWiewAccout";
            this.btnWiewAccout.Size = new System.Drawing.Size(94, 54);
            this.btnWiewAccout.TabIndex = 4;
            this.btnWiewAccout.Text = "Xem";
            this.btnWiewAccout.UseVisualStyleBackColor = true;
            this.btnWiewAccout.Click += new System.EventHandler(this.btnWiewAccout_Click);
            // 
            // btnEditAccout
            // 
            this.btnEditAccout.Location = new System.Drawing.Point(219, -4);
            this.btnEditAccout.Name = "btnEditAccout";
            this.btnEditAccout.Size = new System.Drawing.Size(90, 54);
            this.btnEditAccout.TabIndex = 3;
            this.btnEditAccout.Text = "Sửa";
            this.btnEditAccout.UseVisualStyleBackColor = true;
            this.btnEditAccout.Click += new System.EventHandler(this.btnEditAccout_Click);
            // 
            // btnDeleteAccout
            // 
            this.btnDeleteAccout.Location = new System.Drawing.Point(109, -4);
            this.btnDeleteAccout.Name = "btnDeleteAccout";
            this.btnDeleteAccout.Size = new System.Drawing.Size(94, 54);
            this.btnDeleteAccout.TabIndex = 2;
            this.btnDeleteAccout.Text = "Xóa";
            this.btnDeleteAccout.UseVisualStyleBackColor = true;
            this.btnDeleteAccout.Click += new System.EventHandler(this.btnDeleteAccout_Click);
            // 
            // btnAddAccout
            // 
            this.btnAddAccout.Location = new System.Drawing.Point(0, -4);
            this.btnAddAccout.Name = "btnAddAccout";
            this.btnAddAccout.Size = new System.Drawing.Size(91, 54);
            this.btnAddAccout.TabIndex = 1;
            this.btnAddAccout.Text = "Thêm";
            this.btnAddAccout.UseVisualStyleBackColor = true;
            this.btnAddAccout.Click += new System.EventHandler(this.btnAddAccout_Click);
            // 
            // pnAccountMenu
            // 
            this.pnAccountMenu.Controls.Add(this.btnreEnterPass);
            this.pnAccountMenu.Controls.Add(this.panel28);
            this.pnAccountMenu.Controls.Add(this.panel27);
            this.pnAccountMenu.Controls.Add(this.panel26);
            this.pnAccountMenu.Location = new System.Drawing.Point(444, 95);
            this.pnAccountMenu.Name = "pnAccountMenu";
            this.pnAccountMenu.Size = new System.Drawing.Size(332, 343);
            this.pnAccountMenu.TabIndex = 4;
            // 
            // btnreEnterPass
            // 
            this.btnreEnterPass.Location = new System.Drawing.Point(218, 161);
            this.btnreEnterPass.Name = "btnreEnterPass";
            this.btnreEnterPass.Size = new System.Drawing.Size(94, 54);
            this.btnreEnterPass.TabIndex = 7;
            this.btnreEnterPass.Text = "Đặt Lại Mật Khẩu:";
            this.btnreEnterPass.UseVisualStyleBackColor = true;
            this.btnreEnterPass.Click += new System.EventHandler(this.btnreEnterPass_Click);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.nmTypeAccount);
            this.panel28.Controls.Add(this.lbAccountType);
            this.panel28.Location = new System.Drawing.Point(7, 99);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(322, 41);
            this.panel28.TabIndex = 6;
            // 
            // nmTypeAccount
            // 
            this.nmTypeAccount.Location = new System.Drawing.Point(162, 14);
            this.nmTypeAccount.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmTypeAccount.Name = "nmTypeAccount";
            this.nmTypeAccount.Size = new System.Drawing.Size(52, 20);
            this.nmTypeAccount.TabIndex = 1;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountType.Location = new System.Drawing.Point(6, 18);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(130, 19);
            this.lbAccountType.TabIndex = 0;
            this.lbAccountType.Text = "Loại Tài Khoản:";
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbDisplayName);
            this.panel27.Controls.Add(this.lbAccountName);
            this.panel27.Location = new System.Drawing.Point(7, 51);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(322, 42);
            this.panel27.TabIndex = 5;
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(149, 19);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(156, 20);
            this.txbDisplayName.TabIndex = 1;
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.Location = new System.Drawing.Point(21, 20);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(111, 19);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "Tên Hiển Thị:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.txbUserName);
            this.panel26.Controls.Add(this.lbIdAccout);
            this.panel26.Location = new System.Drawing.Point(10, 3);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(322, 42);
            this.panel26.TabIndex = 4;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(146, 17);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(157, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // lbIdAccout
            // 
            this.lbIdAccout.AutoSize = true;
            this.lbIdAccout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdAccout.Location = new System.Drawing.Point(3, 18);
            this.lbIdAccout.Name = "lbIdAccout";
            this.lbIdAccout.Size = new System.Drawing.Size(126, 19);
            this.lbIdAccout.TabIndex = 0;
            this.lbIdAccout.Text = "Tên Tài Khoản:";
            // 
            // frmAdminAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnAccountMenu);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.dtgAccount);
            this.Name = "frmAdminAccount";
            this.Text = "frmAdminAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.panel21.ResumeLayout(false);
            this.pnAccountMenu.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnWiewAccout;
        private System.Windows.Forms.Button btnEditAccout;
        private System.Windows.Forms.Button btnDeleteAccout;
        private System.Windows.Forms.Button btnAddAccout;
        private System.Windows.Forms.Panel pnAccountMenu;
        private System.Windows.Forms.Button btnreEnterPass;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.NumericUpDown nmTypeAccount;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbIdAccout;
    }
}