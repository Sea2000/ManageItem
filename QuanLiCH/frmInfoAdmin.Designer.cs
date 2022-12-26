namespace QuanLiCH
{
    partial class frmInfoAdmin
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
            this.AdminStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíDoanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíThứcĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíDoanhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hướngDẫnSửaDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdminStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminStrip1
            // 
            this.AdminStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.AdminStrip1.Location = new System.Drawing.Point(0, 0);
            this.AdminStrip1.Name = "AdminStrip1";
            this.AdminStrip1.Size = new System.Drawing.Size(800, 24);
            this.AdminStrip1.TabIndex = 0;
            this.AdminStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLíDoanhThuToolStripMenuItem,
            this.quảnLíThứcĂnToolStripMenuItem,
            this.quảnLíDoanhMụcToolStripMenuItem,
            this.quảnLíTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            this.hệThốngToolStripMenuItem.Click += new System.EventHandler(this.hệThốngToolStripMenuItem_Click);
            // 
            // quảnLíDoanhThuToolStripMenuItem
            // 
            this.quảnLíDoanhThuToolStripMenuItem.Name = "quảnLíDoanhThuToolStripMenuItem";
            this.quảnLíDoanhThuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíDoanhThuToolStripMenuItem.Text = "Quản lí doanh thu";
            this.quảnLíDoanhThuToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDoanhThuToolStripMenuItem_Click);
            // 
            // quảnLíThứcĂnToolStripMenuItem
            // 
            this.quảnLíThứcĂnToolStripMenuItem.Name = "quảnLíThứcĂnToolStripMenuItem";
            this.quảnLíThứcĂnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíThứcĂnToolStripMenuItem.Text = "Quản lí thức ăn";
            this.quảnLíThứcĂnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíThứcĂnToolStripMenuItem_Click);
            // 
            // quảnLíDoanhMụcToolStripMenuItem
            // 
            this.quảnLíDoanhMụcToolStripMenuItem.Name = "quảnLíDoanhMụcToolStripMenuItem";
            this.quảnLíDoanhMụcToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíDoanhMụcToolStripMenuItem.Text = "Quản lí doanh mục";
            this.quảnLíDoanhMụcToolStripMenuItem.Click += new System.EventHandler(this.quảnLíDoanhMụcToolStripMenuItem_Click);
            // 
            // quảnLíTàiKhoảnToolStripMenuItem
            // 
            this.quảnLíTàiKhoảnToolStripMenuItem.Name = "quảnLíTàiKhoảnToolStripMenuItem";
            this.quảnLíTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLíTàiKhoảnToolStripMenuItem.Text = "Quản lí tài khoản";
            this.quảnLíTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLíTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnSửaDụngToolStripMenuItem,
            this.thôngTinPhầnMềmToolStripMenuItem});
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // hướngDẫnSửaDụngToolStripMenuItem
            // 
            this.hướngDẫnSửaDụngToolStripMenuItem.Name = "hướngDẫnSửaDụngToolStripMenuItem";
            this.hướngDẫnSửaDụngToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.hướngDẫnSửaDụngToolStripMenuItem.Text = "Hướng dẫn sửa dụng";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.thôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 139;
            this.iconPictureBox1.Location = new System.Drawing.Point(299, 126);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(170, 139);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Blue;
            this.lblThongBao.Location = new System.Drawing.Point(44, 295);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(708, 32);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "Chào mừng bạn đến với hệ thống quản lý cửa hàng coffee";
            // 
            // frmInfoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.AdminStrip1);
            this.MainMenuStrip = this.AdminStrip1;
            this.Name = "frmInfoAdmin";
            this.Text = "frmInfoAdmin";
            this.AdminStrip1.ResumeLayout(false);
            this.AdminStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AdminStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíDoanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnSửaDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíThứcĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíDoanhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Timer timer1;
    }
}