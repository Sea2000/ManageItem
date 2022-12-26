namespace QuanLiCH.Admin
{
    partial class frmAccount
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
            this.btnreEnterPass = new System.Windows.Forms.Button();
            this.panel28 = new System.Windows.Forms.Panel();
            this.nmTypeAccount = new System.Windows.Forms.NumericUpDown();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.panel26 = new System.Windows.Forms.Panel();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.lbIdAccout = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnDeleteAccout = new System.Windows.Forms.Button();
            this.btnUpdateAccout = new System.Windows.Forms.Button();
            this.btnAddAccout = new System.Windows.Forms.Button();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAccountName = new System.Windows.Forms.Label();
            this.txbDisplayName = new System.Windows.Forms.TextBox();
            this.panel27 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).BeginInit();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).BeginInit();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgAccount
            // 
            this.dtgAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccount.Location = new System.Drawing.Point(14, 164);
            this.dtgAccount.Name = "dtgAccount";
            this.dtgAccount.RowHeadersWidth = 51;
            this.dtgAccount.Size = new System.Drawing.Size(760, 295);
            this.dtgAccount.TabIndex = 1;
            this.dtgAccount.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAccount_CellContentClick);
            // 
            // btnreEnterPass
            // 
            this.btnreEnterPass.BackColor = System.Drawing.Color.Honeydew;
            this.btnreEnterPass.Location = new System.Drawing.Point(655, 116);
            this.btnreEnterPass.Name = "btnreEnterPass";
            this.btnreEnterPass.Size = new System.Drawing.Size(110, 31);
            this.btnreEnterPass.TabIndex = 7;
            this.btnreEnterPass.Text = "Reset Password";
            this.btnreEnterPass.UseVisualStyleBackColor = false;
            this.btnreEnterPass.Click += new System.EventHandler(this.btnreEnterPass_Click);
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.nmTypeAccount);
            this.panel28.Controls.Add(this.lbAccountType);
            this.panel28.Location = new System.Drawing.Point(16, 109);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(303, 41);
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
            this.lbAccountType.Size = new System.Drawing.Size(119, 19);
            this.lbAccountType.TabIndex = 0;
            this.lbAccountType.Text = "Type Account:";
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.lbAccountName);
            this.panel26.Controls.Add(this.txbDisplayName);
            this.panel26.Controls.Add(this.txtphone);
            this.panel26.Controls.Add(this.label1);
            this.panel26.Location = new System.Drawing.Point(351, 43);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(303, 64);
            this.panel26.TabIndex = 4;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(135, 39);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(157, 20);
            this.txtphone.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(125, 18);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(157, 20);
            this.txbUserName.TabIndex = 1;
            // 
            // lbIdAccout
            // 
            this.lbIdAccout.AutoSize = true;
            this.lbIdAccout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdAccout.Location = new System.Drawing.Point(8, 15);
            this.lbIdAccout.Name = "lbIdAccout";
            this.lbIdAccout.Size = new System.Drawing.Size(95, 19);
            this.lbIdAccout.TabIndex = 0;
            this.lbIdAccout.Text = "UserName:";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(316, 8);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(109, 31);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Account";
            // 
            // btnDeleteAccout
            // 
            this.btnDeleteAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccout.Location = new System.Drawing.Point(554, 113);
            this.btnDeleteAccout.Name = "btnDeleteAccout";
            this.btnDeleteAccout.Size = new System.Drawing.Size(77, 34);
            this.btnDeleteAccout.TabIndex = 1;
            this.btnDeleteAccout.Text = "Delete";
            this.btnDeleteAccout.UseVisualStyleBackColor = false;
            this.btnDeleteAccout.Click += new System.EventHandler(this.btnDeleteteAccout_Click);
            // 
            // btnUpdateAccout
            // 
            this.btnUpdateAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateAccout.Location = new System.Drawing.Point(447, 113);
            this.btnUpdateAccout.Name = "btnUpdateAccout";
            this.btnUpdateAccout.Size = new System.Drawing.Size(84, 34);
            this.btnUpdateAccout.TabIndex = 1;
            this.btnUpdateAccout.Text = "Update";
            this.btnUpdateAccout.UseVisualStyleBackColor = false;
            this.btnUpdateAccout.Click += new System.EventHandler(this.btnUpdateAccout_Click);
            // 
            // btnAddAccout
            // 
            this.btnAddAccout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddAccout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAccout.Location = new System.Drawing.Point(348, 113);
            this.btnAddAccout.Name = "btnAddAccout";
            this.btnAddAccout.Size = new System.Drawing.Size(79, 34);
            this.btnAddAccout.TabIndex = 1;
            this.btnAddAccout.Text = "Add";
            this.btnAddAccout.UseVisualStyleBackColor = false;
            this.btnAddAccout.Click += new System.EventHandler(this.btnAddAccout_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(139, 89);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(156, 20);
            this.txtfullname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "FullName:";
            // 
            // lbAccountName
            // 
            this.lbAccountName.AutoSize = true;
            this.lbAccountName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountName.Location = new System.Drawing.Point(3, 14);
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(120, 19);
            this.lbAccountName.TabIndex = 0;
            this.lbAccountName.Text = "Display Name:";
            // 
            // txbDisplayName
            // 
            this.txbDisplayName.Location = new System.Drawing.Point(135, 15);
            this.txbDisplayName.Name = "txbDisplayName";
            this.txbDisplayName.Size = new System.Drawing.Size(156, 20);
            this.txbDisplayName.TabIndex = 1;
            this.txbDisplayName.TextChanged += new System.EventHandler(this.txbDisplayName_TextChanged);
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.txbUserName);
            this.panel27.Controls.Add(this.lbIdAccout);
            this.panel27.Location = new System.Drawing.Point(14, 43);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(305, 42);
            this.panel27.TabIndex = 5;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 471);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel27);
            this.Controls.Add(this.panel28);
            this.Controls.Add(this.btnreEnterPass);
            this.Controls.Add(this.btnDeleteAccout);
            this.Controls.Add(this.btnUpdateAccout);
            this.Controls.Add(this.btnAddAccout);
            this.Controls.Add(this.panel26);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dtgAccount);
            this.Name = "frmAccount";
            this.Text = "frmAccount";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccount)).EndInit();
            this.panel28.ResumeLayout(false);
            this.panel28.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmTypeAccount)).EndInit();
            this.panel26.ResumeLayout(false);
            this.panel26.PerformLayout();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAccount;
        private System.Windows.Forms.Button btnreEnterPass;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.NumericUpDown nmTypeAccount;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label lbIdAccout;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnAddAccout;
        private System.Windows.Forms.Button btnUpdateAccout;
        private System.Windows.Forms.Button btnDeleteAccout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAccountName;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Panel panel27;
    }
}