namespace QuanLiCH
{
    partial class frmAdminTotal
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
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnBillwiew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(118, 153);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(604, 347);
            this.dtgvBill.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.dtpkToDate);
            this.panel12.Controls.Add(this.dtpkFromDate);
            this.panel12.Controls.Add(this.btnBillwiew);
            this.panel12.Location = new System.Drawing.Point(0, 98);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(838, 31);
            this.panel12.TabIndex = 2;
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Location = new System.Drawing.Point(626, 4);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpkToDate.TabIndex = 2;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Location = new System.Drawing.Point(7, 4);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(205, 20);
            this.dtpkFromDate.TabIndex = 1;
            // 
            // btnBillwiew
            // 
            this.btnBillwiew.Location = new System.Drawing.Point(361, 0);
            this.btnBillwiew.Name = "btnBillwiew";
            this.btnBillwiew.Size = new System.Drawing.Size(144, 27);
            this.btnBillwiew.TabIndex = 0;
            this.btnBillwiew.Text = "Doanh Thu";
            this.btnBillwiew.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 92);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.label1.Location = new System.Drawing.Point(354, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu ";
            // 
            // frmAdminTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dtgvBill);
            this.Name = "frmAdminTotal";
            this.Text = "frmTotal";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Button btnBillwiew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}