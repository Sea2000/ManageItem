 namespace QuanLiCH
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnTitleBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCloseChillForm = new System.Windows.Forms.Button();
            this.lbTitleBar = new System.Windows.Forms.Label();
            this.pnDesktopPane = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnItemReturn = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.pnTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnMenu.Controls.Add(this.btnItemReturn);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnCategory);
            this.pnMenu.Controls.Add(this.btnFood);
            this.pnMenu.Controls.Add(this.btnBill);
            this.pnMenu.Controls.Add(this.pnLogo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(128, 577);
            this.pnMenu.TabIndex = 0;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 268);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(128, 60);
            this.btnAccount.TabIndex = 6;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.Yellow;
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 208);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(128, 60);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Directory";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnFood
            // 
            this.btnFood.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 148);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(128, 60);
            this.btnFood.TabIndex = 4;
            this.btnFood.Text = "Items";
            this.btnFood.UseVisualStyleBackColor = false;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(0, 85);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(128, 63);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Statictics";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.Teal;
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(128, 85);
            this.pnLogo.TabIndex = 0;
            // 
            // pnTitleBar
            // 
            this.pnTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.pnTitleBar.Controls.Add(this.btnExit);
            this.pnTitleBar.Controls.Add(this.btnMaximize);
            this.pnTitleBar.Controls.Add(this.btnMinimize);
            this.pnTitleBar.Controls.Add(this.btnCloseChillForm);
            this.pnTitleBar.Controls.Add(this.lbTitleBar);
            this.pnTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitleBar.Location = new System.Drawing.Point(128, 0);
            this.pnTitleBar.Name = "pnTitleBar";
            this.pnTitleBar.Size = new System.Drawing.Size(925, 60);
            this.pnTitleBar.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Image = global::QuanLiCH.Properties.Resources._4115230_cancel_close_cross_delete_1140481;
            this.btnExit.Location = new System.Drawing.Point(741, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaximize.Image = global::QuanLiCH.Properties.Resources.software_shape_rectangle_98272__1_1;
            this.btnMaximize.Location = new System.Drawing.Point(699, 6);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(28, 29);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMinimize.Image = global::QuanLiCH.Properties.Resources.minimize_118918;
            this.btnMinimize.Location = new System.Drawing.Point(657, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 29);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCloseChillForm
            // 
            this.btnCloseChillForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChillForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChillForm.Image = global::QuanLiCH.Properties.Resources._4115230_cancel_close_cross_delete_114048;
            this.btnCloseChillForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChillForm.Name = "btnCloseChillForm";
            this.btnCloseChillForm.Size = new System.Drawing.Size(112, 60);
            this.btnCloseChillForm.TabIndex = 1;
            this.btnCloseChillForm.UseVisualStyleBackColor = true;
            this.btnCloseChillForm.Click += new System.EventHandler(this.btnCloseChillForm_Click);
            // 
            // lbTitleBar
            // 
            this.lbTitleBar.AutoSize = true;
            this.lbTitleBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleBar.Location = new System.Drawing.Point(368, 14);
            this.lbTitleBar.Name = "lbTitleBar";
            this.lbTitleBar.Size = new System.Drawing.Size(75, 26);
            this.lbTitleBar.TabIndex = 0;
            this.lbTitleBar.Text = "HOME";
            // 
            // pnDesktopPane
            // 
            this.pnDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktopPane.Location = new System.Drawing.Point(128, 60);
            this.pnDesktopPane.Name = "pnDesktopPane";
            this.pnDesktopPane.Size = new System.Drawing.Size(925, 517);
            this.pnDesktopPane.TabIndex = 2;
            // 
            // btnItemReturn
            // 
            this.btnItemReturn.BackColor = System.Drawing.Color.Fuchsia;
            this.btnItemReturn.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItemReturn.FlatAppearance.BorderSize = 0;
            this.btnItemReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnItemReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItemReturn.Location = new System.Drawing.Point(0, 328);
            this.btnItemReturn.Name = "btnItemReturn";
            this.btnItemReturn.Size = new System.Drawing.Size(128, 63);
            this.btnItemReturn.TabIndex = 7;
            this.btnItemReturn.Text = "ItemReturn";
            this.btnItemReturn.UseVisualStyleBackColor = false;
            this.btnItemReturn.Click += new System.EventHandler(this.btnItemReturn_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 577);
            this.Controls.Add(this.pnDesktopPane);
            this.Controls.Add(this.pnTitleBar);
            this.Controls.Add(this.pnMenu);
            this.Name = "frmAdmin";
            this.Text = "Admin Manage";
            this.pnMenu.ResumeLayout(false);
            this.pnTitleBar.ResumeLayout(false);
            this.pnTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel pnTitleBar;
        private System.Windows.Forms.Label lbTitleBar;
        private System.Windows.Forms.Panel pnDesktopPane;
        private System.Windows.Forms.Button btnCloseChillForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnItemReturn;
    }
}