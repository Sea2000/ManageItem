using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using QuanLiCH.DAO_1;
using QuanLiCH.DTO_1;

namespace QuanLiCH.Admin
{
    public partial class frmItemReturn : Form
    {
        private Panel panel12;
        private ComboBox cbItems;
        private CheckBox chkitem;
        private DateTimePicker dtgkToDate;
        private DateTimePicker dtgkFromDate;
        private Button btnItemReturnView;
        private DataGridView dtgvItemReturn;

        public frmItemReturn()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadItemsIntoCombobox(cbItems);
            List<ItemReturn> listitemreturn = ItemReturnDAO.Instance.GetListitem();
            dtgvItemReturn.DataSource = listitemreturn;

        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtgkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtgkToDate.Value = dtgkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void LoadListStatictisByDate(DateTime datefrom, DateTime dateto)
        {
            dtgvItemReturn.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByDate(datefrom, dateto);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }

        void LoadListStatictisByItemanddate(DateTime datefrom, DateTime dateto, string nameitem)
        {
            dtgvItemReturn.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByNameitemandDate(datefrom, dateto, nameitem);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }


        void LoadItemsIntoCombobox(ComboBox cb)
        {
            cb.DataSource = ItemsDAO.Instance.GetListitem();
            cb.DisplayMember = "NameItem";
        }

        private void btnItemReturnView_Click(object sender, EventArgs e)
        {
            if (chkitem.Checked == true)
            {
                string nameitem = cbItems.Text;
                LoadListStatictisByItemanddate(dtgkFromDate.Value, dtgkToDate.Value, nameitem);
            }
            else
            {
                LoadListStatictisByDate(dtgkFromDate.Value, dtgkToDate.Value);
            }
        }
        private void InitializeComponent()
        {
            this.dtgvItemReturn = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.chkitem = new System.Windows.Forms.CheckBox();
            this.dtgkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtgkFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnItemReturnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItemReturn)).BeginInit();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvItemReturn
            // 
            this.dtgvItemReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvItemReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvItemReturn.Location = new System.Drawing.Point(25, 61);
            this.dtgvItemReturn.Name = "dtgvItemReturn";
            this.dtgvItemReturn.Size = new System.Drawing.Size(1052, 395);
            this.dtgvItemReturn.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel12.Controls.Add(this.cbItems);
            this.panel12.Controls.Add(this.chkitem);
            this.panel12.Controls.Add(this.dtgkToDate);
            this.panel12.Controls.Add(this.dtgkFromDate);
            this.panel12.Controls.Add(this.btnItemReturnView);
            this.panel12.Location = new System.Drawing.Point(69, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(799, 31);
            this.panel12.TabIndex = 3;
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
            // btnItemReturnView
            // 
            this.btnItemReturnView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnItemReturnView.Location = new System.Drawing.Point(217, 4);
            this.btnItemReturnView.Name = "btnItemReturnView";
            this.btnItemReturnView.Size = new System.Drawing.Size(144, 27);
            this.btnItemReturnView.TabIndex = 0;
            this.btnItemReturnView.Text = "Statistic";
            this.btnItemReturnView.UseVisualStyleBackColor = true;
            this.btnItemReturnView.Click += new System.EventHandler(this.btnItemReturnView_Click);
            // 
            // frmItemReturn
            // 
            this.ClientSize = new System.Drawing.Size(1108, 501);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.dtgvItemReturn);
            this.Name = "frmItemReturn";
            this.Text = "frmItemReturn";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvItemReturn)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

    }
}
