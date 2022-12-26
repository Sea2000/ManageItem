namespace QuanLiCH.Admin
{
    partial class frmCategory
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
            this.pnCategoryName = new System.Windows.Forms.Panel();
            this.cbCategoryName = new System.Windows.Forms.ComboBox();
            this.lbMenuName = new System.Windows.Forms.Label();
            this.pnCategoryID = new System.Windows.Forms.Panel();
            this.txbCategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            this.pnCategoryName.SuspendLayout();
            this.pnCategoryID.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategory
            // 
            this.dtgCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(12, 188);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.RowHeadersWidth = 51;
            this.dtgCategory.Size = new System.Drawing.Size(794, 238);
            this.dtgCategory.TabIndex = 1;
            // 
            // pnCategoryName
            // 
            this.pnCategoryName.Controls.Add(this.cbCategoryName);
            this.pnCategoryName.Controls.Add(this.lbMenuName);
            this.pnCategoryName.Location = new System.Drawing.Point(477, 61);
            this.pnCategoryName.Name = "pnCategoryName";
            this.pnCategoryName.Size = new System.Drawing.Size(329, 48);
            this.pnCategoryName.TabIndex = 4;
            // 
            // cbCategoryName
            // 
            this.cbCategoryName.FormattingEnabled = true;
            this.cbCategoryName.Location = new System.Drawing.Point(131, 16);
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
            this.lbMenuName.Size = new System.Drawing.Size(137, 19);
            this.lbMenuName.TabIndex = 0;
            this.lbMenuName.Text = "Category Name :";
            // 
            // pnCategoryID
            // 
            this.pnCategoryID.Controls.Add(this.txbCategoryID);
            this.pnCategoryID.Controls.Add(this.label5);
            this.pnCategoryID.Location = new System.Drawing.Point(20, 61);
            this.pnCategoryID.Name = "pnCategoryID";
            this.pnCategoryID.Size = new System.Drawing.Size(311, 42);
            this.pnCategoryID.TabIndex = 2;
            // 
            // txbCategoryID
            // 
            this.txbCategoryID.Location = new System.Drawing.Point(131, 11);
            this.txbCategoryID.Name = "txbCategoryID";
            this.txbCategoryID.ReadOnly = true;
            this.txbCategoryID.Size = new System.Drawing.Size(167, 20);
            this.txbCategoryID.TabIndex = 1;
            this.txbCategoryID.TextChanged += new System.EventHandler(this.txbCategoryID_TextChanged);
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
            // lb1
            // 
            this.lb1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(371, 9);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(105, 28);
            this.lb1.TabIndex = 5;
            this.lb1.Text = "Directory";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(129, 129);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdateFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateFood.Location = new System.Drawing.Point(20, 129);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(86, 29);
            this.btnUpdateFood.TabIndex = 1;
            this.btnUpdateFood.Text = "Update";
            this.btnUpdateFood.UseVisualStyleBackColor = false;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.Location = new System.Drawing.Point(230, 129);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(74, 29);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Add";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 438);
            this.Controls.Add(this.pnCategoryName);
            this.Controls.Add(this.pnCategoryID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.dtgCategory);
            this.Name = "frmCategory";
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
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
        private System.Windows.Forms.Panel pnCategoryName;
        private System.Windows.Forms.ComboBox cbCategoryName;
        private System.Windows.Forms.Label lbMenuName;
        private System.Windows.Forms.Panel pnCategoryID;
        private System.Windows.Forms.TextBox txbCategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnDelete;
    }
}