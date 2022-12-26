using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiCH.DTO_1;

namespace QuanLiCH
{
    public partial class frmInfoAdmin : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public Action<object, EventArgs> InsertFood { get; internal set; }
        public Action<object, EventArgs> DeleteFood { get; internal set; }
        public Action<object, EventArgs> UpdateFood { get; internal set; }

        
        public frmInfoAdmin(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }
        public void ChangeAccount(int type)
        {
            if (hệThốngToolStripMenuItem.Enabled = type == 1)
            {
                this.Text = "Xin chào Admin"+ hệThốngToolStripMenuItem;
            }
            else
            {
                MessageBox.Show("Xin chào vui lòng đăng nhập bằng tài khoản Admin ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }    

        }

        private void quảnLíDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminTotal fat=new frmAdminTotal();
            this.Hide();
            fat.ShowDialog();
            this.Close();
        }

        private void quảnLíThứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminFood fad= new frmAdminFood();
            this.Hide();
            fad.ShowDialog();
            this.Close();
        }

        private void quảnLíDoanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminCategory fac=new frmAdminCategory();
            this.Hide();
            fac.ShowDialog();
            this.Close();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminAccount faa=new frmAdminAccount();
            this.Hide();
            faa.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIA frmIA = new frmIA();
            this.Hide();
            frmIA.ShowDialog();
            this.Close();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
