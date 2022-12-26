using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DTO_1;

namespace QuanLiCH.Admin
{
    public partial class frmAccount : Form
    {
        BindingSource accountList = new BindingSource();
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }



        public frmAccount()
        {
            InitializeComponent();
            LoadTheme();
          
            dtgAccount.DataSource = accountList;
            AddAccountBinding();
            LoadAccount();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(135, 206, 250);
                    btn.ForeColor = Color.Gainsboro;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryyColor;
                }
                lb1.ForeColor = ThemeColor.SecondaryyColor;
               
            }



        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtfullname.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "FullName", true, DataSourceUpdateMode.Never));
            txtphone.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "phone", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmTypeAccount.DataBindings.Add(new Binding("Value", dtgAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void AddAccount(string name,string fullname, string displayName,string phone, int type)
        {
            try
            {
                if (AccountDAO.Instance.InsertAccount(name,  fullname,  displayName,  phone,  type))
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại");
                }

               
            }
            catch { }
            LoadAccount();
        }
        void EditAccount(string userName,string fullname, string displayName,string phone, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, fullname, displayName, phone, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
 
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }


        private void btnAddAccout_Click(object sender, EventArgs e)
        {

            string userName = txbUserName.Text;
            string fullname = txtfullname.Text;
            string phone = txtphone.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmTypeAccount.Value;

            if (AccountDAO.Instance.Checkuserexist(userName))
            {
                MessageBox.Show("UserName Has Exist");
            }
            else
            {
                AddAccount(userName, fullname, displayName, phone, type);
            }
           
        }

        private void btnDeleteteAccout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(string.Format("Bạn có chắc thanh xóa dòng dữ liệu này"), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)

            {
                string userName = txbUserName.Text;

                DeleteAccount(userName);
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thực hiện");
            }
            
        }



        private void btnEditAccout_Click(object sender, EventArgs e)
        {
           
        }
        private void btnUpdateAccout_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            string fullname = txbUserName.Text;
            string phone = txtphone.Text;
            int type = (int)nmTypeAccount.Value;

            EditAccount(userName,fullname, displayName,phone, type);
        }
        private void btnWiewAccout_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnreEnterPass_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;

            ResetPass(userName);
        }

        private void txbDisplayName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
