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
    public partial class frmStatistic : Form
    {
        public frmStatistic()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadItemsIntoCombobox(cbItems);
            LoadSellerIntoCombobox(cbseller);
            List<QuanLiCH.DTO_1.ShowtableStatistic> litstatistic = ShowtableStatisticDAO.Instance.getliststatistics();
            dtgvStatistic.DataSource = litstatistic;

        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtgkFromDate.Value = new DateTime(today.Year, today.Month, 1 );
            dtgkToDate.Value = dtgkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void LoadListStatictisByDate(DateTime datefrom, DateTime dateto)
        {
            dtgvStatistic.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByDate(datefrom, dateto);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }

        void LoadListStatictisByItemanddate(DateTime datefrom, DateTime dateto ,string nameitem )
        {
            dtgvStatistic.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByNameitemandDate(datefrom, dateto,nameitem);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }

        void LoadListStatictisByItemanddateandseller(DateTime datefrom, DateTime dateto, string nameitem , string seller)
        {
            dtgvStatistic.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByNameitemandDateandseller(datefrom, dateto, nameitem, seller);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }

        void LoadListStatictisByseller(DateTime datefrom, DateTime dateto, string seller)
        {
            dtgvStatistic.DataSource = ShowtableStatisticDAO.Instance.GetListStatisticByseller(datefrom, dateto, seller);
            //dtgvBill.DataSource = BillDAO.Instance.GetlistBill();
        }


        private void btnBillwiew_Click(object sender, EventArgs e)
        {

            if (chkitem.Checked == true)
            {
                string nameitem =cbItems.Text;
                LoadListStatictisByItemanddate(dtgkFromDate.Value, dtgkToDate.Value,nameitem);
                if (chkseller.Checked == true)
                {
                    string seller = cbseller.Text;
                    LoadListStatictisByItemanddateandseller(dtgkFromDate.Value, dtgkToDate.Value, nameitem , seller);
                }
            }
            else if (chkseller.Checked == true && chkitem.Checked ==false)
            {
                string seller = cbseller.Text;
                LoadListStatictisByseller(dtgkFromDate.Value, dtgkToDate.Value, seller);
            }
            else 
            {
                LoadListStatictisByDate(dtgkFromDate.Value, dtgkToDate.Value);

            }

        }

        void LoadItemsIntoCombobox(ComboBox cb)
        {
            cb.DataSource = ItemsDAO.Instance.GetListitem();
            cb.DisplayMember = "NameItem";
        }

        

         void LoadSellerIntoCombobox(ComboBox cb)
        {
            cb.DataSource = AccountDAO.Instance.GetListAccount();
            cb.DisplayMember = "DisplayName";
        }
    }
}
