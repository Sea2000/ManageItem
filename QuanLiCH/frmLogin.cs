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

namespace QuanLiCH
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txbPassword.Text;
            if (Login(userName, password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
        bool Login(string userName, string password)
        {
            return AccountDAO.Instance.Login(userName, password);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowpass.Checked)
            {
                txbPassword.UseSystemPasswordChar = true;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Wiew";
            }
            else
            {

                txbPassword.UseSystemPasswordChar = false;
                var checkBox = (CheckBox)sender;
                checkBox.Text = "Hide";
            }

        }
    }
}
