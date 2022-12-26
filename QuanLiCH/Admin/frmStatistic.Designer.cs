namespace QuanLiCH.Admin
{
    partial class frmStatistic
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
            this.dtgvStatistic = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbseller = new System.Windows.Forms.ComboBox();
            this.chkseller = new System.Windows.Forms.CheckBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.chkitem = new System.Windows.Forms.CheckBox();
            this.dtgkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtgkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnBillview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistic)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvStatistic
            // 
            this.dtgvStatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStatistic.Location = new System.Drawing.Point(7, 62);
            this.dtgvStatistic.Name = "dtgvStatistic";
            this.dtgvStatistic.Size = new System.Drawing.Size(1052, 395);
            this.dtgvStatistic.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.cbseller);
            this.panel12.Controls.Add(this.chkseller);
            this.panel12.Controls.Add(this.cbItems);
            this.panel12.Controls.Add(this.chkitem);
            this.panel12.Controls.Add(this.dtgkToDate);
            this.panel12.Controls.Add(this.dtgkFromDate);
            this.panel12.Controls.Add(this.btnBillview);
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1071, 31);
            this.panel12.TabIndex = 2;
            // 
            // cbseller
            // 
            this.cbseller.FormattingEnabled = true;
            this.cbseller.Location = new System.Drawing.Point(837, 7);
            this.cbseller.Name = "cbseller";
            this.cbseller.Size = new System.Drawing.Size(151, 21);
            this.cbseller.TabIndex = 4;
            // 
            // chkseller
            // 
            this.chkseller.AutoSize = true;
            this.chkseller.Location = new System.Drawing.Point(785, 9);
            this.chkseller.Name = "chkseller";
            this.chkseller.Size = new System.Drawing.Size(50, 17);
            this.chkseller.TabIndex = 5;
            this.chkseller.Text = "seller";
            this.chkseller.UseVisualStyleBackColor = true;
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(625, 8);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(151, 21);
            this.cbItems.TabIndex = 3;
            // 
            // chkitem
            // 
            this.chkitem.AutoSize = true;
            this.chkitem.Location = new System.Drawing.Point(573, 10);
            this.chkitem.Name = "chkitem";
            this.chkitem.Size = new System.Drawing.Size(46, 17);
            this.chkitem.TabIndex = 3;
            this.chkitem.Text = "Item";
            this.chkitem.UseVisualStyleBackColor = true;
            // 
            // dtgkToDate
            // 
            this.dtgkToDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgkToDate.Location = new System.Drawing.Point(367, 8);
            this.dtgkToDate.Name = "dtgkToDate";
            this.dtgkToDate.Size = new System.Drawing.Size(200, 20);
            this.dtgkToDate.TabIndex = 2;
            // 
            // dtgkFromDate
            // 
            this.dtgkFromDate.Location = new System.Drawing.Point(26, 8);
            this.dtgkFromDate.Name = "dtgkFromDate";
            this.dtgkFromDate.Size = new System.Drawing.Size(185, 20);
            this.dtgkFromDate.TabIndex = 1;
            // 
            // btnBillview
            // 
            this.btnBillview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBillview.Location = new System.Drawing.Point(217, 4);
            this.btnBillview.Name = "btnBillview";
            this.btnBillview.Size = new System.Drawing.Size(144, 27);
            this.btnBillview.TabIndex = 0;
            this.btnBillview.Text = "Statistic";
            this.btnBillview.UseVisualStyleBackColor = true;
            this.btnBillview.Click += new System.EventHandler(this.btnBillwiew_Click);
            // 
            // frmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 469);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dtgvStatistic);
            this.Name = "frmStatistic";
            this.Text = "frmStatistic";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStatistic)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvStatistic;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dtgkToDate;
        private System.Windows.Forms.DateTimePicker dtgkFromDate;
        private System.Windows.Forms.Button btnBillview;
        private System.Windows.Forms.CheckBox chkitem;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.ComboBox cbseller;
        private System.Windows.Forms.CheckBox chkseller;
    }
}