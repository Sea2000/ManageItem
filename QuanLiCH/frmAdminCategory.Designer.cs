namespace QuanLiCH
{
    partial class frmAdminCategory
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
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.btnWiewCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.pnCategoryName = new System.Windows.Forms.Panel();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.pnCategoryID = new System.Windows.Forms.Panel();
            this.tbIdCategory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            this.pnCategoryName.SuspendLayout();
            this.pnCategoryID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategory
            // 
            this.dtgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(33, 144);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.Size = new System.Drawing.Size(833, 335);
            this.dtgCategory.TabIndex = 1;
            // 
            // btnWiewCategory
            // 
            this.btnWiewCategory.Location = new System.Drawing.Point(33, 582);
            this.btnWiewCategory.Name = "btnWiewCategory";
            this.btnWiewCategory.Size = new System.Drawing.Size(90, 35);
            this.btnWiewCategory.TabIndex = 4;
            this.btnWiewCategory.Text = "Xem";
            this.btnWiewCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(379, 582);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(90, 35);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(265, 582);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(90, 35);
            this.btnDeleteCategory.TabIndex = 2;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(147, 582);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(90, 35);
            this.btnAddCategory.TabIndex = 1;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // pnCategoryName
            // 
            this.pnCategoryName.Controls.Add(this.cbCategoryName);
            this.pnCategoryName.Controls.Add(this.lbMenuName);
            this.pnCategoryName.Location = new System.Drawing.Point(488, 25);
            this.pnCategoryName.Name = "pnCategoryName";
            this.pnCategoryName.Size = new System.Drawing.Size(333, 48);
            this.pnCategoryName.TabIndex = 4;
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(134, 16);
            this.cbCategoryName.Name = "cbCategoryName";
            this.cbCategoryName.Size = new System.Drawing.Size(191, 21);
            this.cbCategoryName.TabIndex = 1;
            // 
            // lbMenuName
            // 
            this.lbMenuName.AutoSize = true;
            this.lbMenuName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenuName.Location = new System.Drawing.Point(3, 18);
            this.lbMenuName.Name = "lbMenuName";
            this.lbMenuName.Size = new System.Drawing.Size(125, 19);
            this.lbMenuName.TabIndex = 0;
            this.lbMenuName.Text = "Tên Danh Mục:";
            // 
            // pnCategoryID
            // 
            this.pnCategoryID.Controls.Add(this.tbIdCategory);
            this.pnCategoryID.Controls.Add(this.label5);
            this.pnCategoryID.Location = new System.Drawing.Point(33, 25);
            this.pnCategoryID.Name = "pnCategoryID";
            this.pnCategoryID.Size = new System.Drawing.Size(322, 42);
            this.pnCategoryID.TabIndex = 2;
            // 
            // tbIdCategory
            // 
            this.tbIdCategory.Location = new System.Drawing.Point(131, 19);
            this.tbIdCategory.Name = "tbIdCategory";
            this.tbIdCategory.ReadOnly = true;
            this.tbIdCategory.Size = new System.Drawing.Size(167, 20);
            this.tbIdCategory.TabIndex = 1;
            this.tbIdCategory.TextChanged += new System.EventHandler(this.tbIdCategory_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(307, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục thức ăn";
            // 
            // frmAdminCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 664);
            this.Controls.Add(this.btnWiewCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.pnCategoryName);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.pnCategoryID);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.dtgCategory);
            this.Name = "frmAdminCategory";
            this.Text = "frmAdminCategory";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            this.pnCategoryName.ResumeLayout(false);
            this.pnCategoryName.PerformLayout();
            this.pnCategoryID.ResumeLayout(false);
            this.pnCategoryID.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.Button btnWiewCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel pnCategoryName;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.Panel pnCategoryID;
        private System.Windows.Forms.TextBox tbIdCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}