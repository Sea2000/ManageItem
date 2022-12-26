namespace QuanLiCH
{
    partial class frmAdminFood
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
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.pnMenuFood = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnADdFood = new System.Windows.Forms.Button();
            this.pnSreach = new System.Windows.Forms.Panel();
            this.txbSreachFoodName = new System.Windows.Forms.TextBox();
            this.btnSreachFood = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnFoodCategory = new System.Windows.Forms.Panel();
            this.cbFoodCategory = new System.Windows.Forms.ComboBox();
            this.lbFoodCategory = new System.Windows.Forms.Label();
            this.pnFoodPrice = new System.Windows.Forms.Panel();
            this.nmFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.lbFoodPrice = new System.Windows.Forms.Label();
            this.pnFoodName = new System.Windows.Forms.Panel();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.pnFoodID = new System.Windows.Forms.Panel();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.lbFoodId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.pnMenuFood.SuspendLayout();
            this.pnSreach.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnFoodCategory.SuspendLayout();
            this.pnFoodPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).BeginInit();
            this.pnFoodName.SuspendLayout();
            this.pnFoodID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Location = new System.Drawing.Point(12, 99);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(410, 339);
            this.dtgvFood.TabIndex = 1;
            // 
            // pnMenuFood
            // 
            this.pnMenuFood.Controls.Add(this.btnShowFood);
            this.pnMenuFood.Controls.Add(this.btnEditFood);
            this.pnMenuFood.Controls.Add(this.btnDeleteFood);
            this.pnMenuFood.Controls.Add(this.btnADdFood);
            this.pnMenuFood.Location = new System.Drawing.Point(11, 40);
            this.pnMenuFood.Name = "pnMenuFood";
            this.pnMenuFood.Size = new System.Drawing.Size(411, 53);
            this.pnMenuFood.TabIndex = 3;
            // 
            // btnShowFood
            // 
            this.btnShowFood.Location = new System.Drawing.Point(296, 1);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(100, 54);
            this.btnShowFood.TabIndex = 3;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = true;
            // 
            // btnEditFood
            // 
            this.btnEditFood.Location = new System.Drawing.Point(200, -2);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(90, 54);
            this.btnEditFood.TabIndex = 2;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(100, 0);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(94, 54);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnADdFood
            // 
            this.btnADdFood.Location = new System.Drawing.Point(3, -1);
            this.btnADdFood.Name = "btnADdFood";
            this.btnADdFood.Size = new System.Drawing.Size(91, 54);
            this.btnADdFood.TabIndex = 0;
            this.btnADdFood.Text = "Thêm";
            this.btnADdFood.UseVisualStyleBackColor = true;
            // 
            // pnSreach
            // 
            this.pnSreach.Controls.Add(this.txbSreachFoodName);
            this.pnSreach.Controls.Add(this.btnSreachFood);
            this.pnSreach.Location = new System.Drawing.Point(441, 12);
            this.pnSreach.Name = "pnSreach";
            this.pnSreach.Size = new System.Drawing.Size(347, 53);
            this.pnSreach.TabIndex = 4;
            // 
            // txbSreachFoodName
            // 
            this.txbSreachFoodName.Location = new System.Drawing.Point(27, 17);
            this.txbSreachFoodName.Name = "txbSreachFoodName";
            this.txbSreachFoodName.Size = new System.Drawing.Size(187, 20);
            this.txbSreachFoodName.TabIndex = 2;
            // 
            // btnSreachFood
            // 
            this.btnSreachFood.Location = new System.Drawing.Point(244, 3);
            this.btnSreachFood.Name = "btnSreachFood";
            this.btnSreachFood.Size = new System.Drawing.Size(100, 54);
            this.btnSreachFood.TabIndex = 1;
            this.btnSreachFood.Text = "Tìm";
            this.btnSreachFood.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnFoodCategory);
            this.panel4.Controls.Add(this.pnFoodPrice);
            this.panel4.Controls.Add(this.pnFoodName);
            this.panel4.Controls.Add(this.pnFoodID);
            this.panel4.Location = new System.Drawing.Point(441, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(342, 348);
            this.panel4.TabIndex = 5;
            // 
            // pnFoodCategory
            // 
            this.pnFoodCategory.Controls.Add(this.cbFoodCategory);
            this.pnFoodCategory.Controls.Add(this.lbFoodCategory);
            this.pnFoodCategory.Location = new System.Drawing.Point(7, 105);
            this.pnFoodCategory.Name = "pnFoodCategory";
            this.pnFoodCategory.Size = new System.Drawing.Size(321, 48);
            this.pnFoodCategory.TabIndex = 5;
            // 
            // cbFoodCategory
            // 
            this.cbFoodCategory.FormattingEnabled = true;
            this.cbFoodCategory.Location = new System.Drawing.Point(102, 18);
            this.cbFoodCategory.Name = "cbFoodCategory";
            this.cbFoodCategory.Size = new System.Drawing.Size(204, 21);
            this.cbFoodCategory.TabIndex = 1;
            // 
            // lbFoodCategory
            // 
            this.lbFoodCategory.AutoSize = true;
            this.lbFoodCategory.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodCategory.Location = new System.Drawing.Point(3, 17);
            this.lbFoodCategory.Name = "lbFoodCategory";
            this.lbFoodCategory.Size = new System.Drawing.Size(92, 19);
            this.lbFoodCategory.TabIndex = 0;
            this.lbFoodCategory.Text = "Danh Mục:";
            // 
            // pnFoodPrice
            // 
            this.pnFoodPrice.Controls.Add(this.nmFoodPrice);
            this.pnFoodPrice.Controls.Add(this.lbFoodPrice);
            this.pnFoodPrice.Location = new System.Drawing.Point(4, 159);
            this.pnFoodPrice.Name = "pnFoodPrice";
            this.pnFoodPrice.Size = new System.Drawing.Size(333, 41);
            this.pnFoodPrice.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            this.nmFoodPrice.Location = new System.Drawing.Point(102, 3);
            this.nmFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmFoodPrice.Name = "nmFoodPrice";
            this.nmFoodPrice.Size = new System.Drawing.Size(206, 20);
            this.nmFoodPrice.TabIndex = 1;
            // 
            // lbFoodPrice
            // 
            this.lbFoodPrice.AutoSize = true;
            this.lbFoodPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodPrice.Location = new System.Drawing.Point(3, 4);
            this.lbFoodPrice.Name = "lbFoodPrice";
            this.lbFoodPrice.Size = new System.Drawing.Size(40, 19);
            this.lbFoodPrice.TabIndex = 0;
            this.lbFoodPrice.Text = "Giá:";
            // 
            // pnFoodName
            // 
            this.pnFoodName.Controls.Add(this.txbFoodName);
            this.pnFoodName.Controls.Add(this.lbFoodName);
            this.pnFoodName.Location = new System.Drawing.Point(0, 55);
            this.pnFoodName.Name = "pnFoodName";
            this.pnFoodName.Size = new System.Drawing.Size(333, 44);
            this.pnFoodName.TabIndex = 2;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Location = new System.Drawing.Point(103, 19);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(205, 20);
            this.txbFoodName.TabIndex = 1;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodName.Location = new System.Drawing.Point(3, 18);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(81, 19);
            this.lbFoodName.TabIndex = 0;
            this.lbFoodName.Text = "Tên Món:";
            // 
            // pnFoodID
            // 
            this.pnFoodID.Controls.Add(this.txbFoodID);
            this.pnFoodID.Controls.Add(this.lbFoodId);
            this.pnFoodID.Location = new System.Drawing.Point(4, 7);
            this.pnFoodID.Name = "pnFoodID";
            this.pnFoodID.Size = new System.Drawing.Size(322, 42);
            this.pnFoodID.TabIndex = 1;
            // 
            // txbFoodID
            // 
            this.txbFoodID.Location = new System.Drawing.Point(102, 19);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.ReadOnly = true;
            this.txbFoodID.Size = new System.Drawing.Size(196, 20);
            this.txbFoodID.TabIndex = 1;
            // 
            // lbFoodId
            // 
            this.lbFoodId.AutoSize = true;
            this.lbFoodId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFoodId.Location = new System.Drawing.Point(21, 20);
            this.lbFoodId.Name = "lbFoodId";
            this.lbFoodId.Size = new System.Drawing.Size(31, 19);
            this.lbFoodId.TabIndex = 0;
            this.lbFoodId.Text = "ID:";
            // 
            // frmAdminFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnSreach);
            this.Controls.Add(this.pnMenuFood);
            this.Controls.Add(this.dtgvFood);
            this.Name = "frmAdminFood";
            this.Text = "frmAdminFood";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.pnMenuFood.ResumeLayout(false);
            this.pnSreach.ResumeLayout(false);
            this.pnSreach.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnFoodCategory.ResumeLayout(false);
            this.pnFoodCategory.PerformLayout();
            this.pnFoodPrice.ResumeLayout(false);
            this.pnFoodPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodPrice)).EndInit();
            this.pnFoodName.ResumeLayout(false);
            this.pnFoodName.PerformLayout();
            this.pnFoodID.ResumeLayout(false);
            this.pnFoodID.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel pnMenuFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Button btnADdFood;
        private System.Windows.Forms.Panel pnSreach;
        private System.Windows.Forms.TextBox txbSreachFoodName;
        private System.Windows.Forms.Button btnSreachFood;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnFoodPrice;
        private System.Windows.Forms.NumericUpDown nmFoodPrice;
        private System.Windows.Forms.Label lbFoodPrice;
        private System.Windows.Forms.Panel pnFoodName;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.Label lbFoodName;
        private System.Windows.Forms.Panel pnFoodID;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label lbFoodId;
        private System.Windows.Forms.Panel pnFoodCategory;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label lbFoodCategory;
    }
}