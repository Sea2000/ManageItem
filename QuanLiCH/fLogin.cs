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
using MetroFramework.Forms;
using static System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager;
using System.IO;
using System.Windows.Shapes;
using System.Windows;
using Application = System.Windows.Forms.Application;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;


namespace QuanLiCH
{
    public partial class fLogin : MetroForm
    {


        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (Login(userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                SavePassword();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
            bool Login(string username, string password)
            {
                return AccountDAO.Instance.Login(userName, passWord);
            }



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowpass.Checked)
            {
                txtPassWord.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassWord.UseSystemPasswordChar = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txtPassWord.UseSystemPasswordChar = true;
        }

        private void chksavepass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnLogin_Click(sender, e);
            }
        }

        private void SavePassword()
        {
            try
            {

                if (chksavepass.Checked)
                {
                    String path = Application.StartupPath + @"\Savepassword.txt"; //@"C:\Học Tập\Do An Co So\Final\QuanLiCH\QuanLiCH\Savepassword.txt";
                    try
                    {
                        using (StreamWriter sr = new StreamWriter(path))
                            sr.WriteLine(txtUserName.Text + ";" + txtPassWord.Text);
                    }
                    catch (Exception e)
                    {

                    }


                }


            }
            catch (Exception e)
            {

            }

        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String pathsp = Application.StartupPath + @"\Savepassword.txt";// @"C:\Học Tập\Do An Co So\Final\QuanLiCH\QuanLiCH\Savepassword.txt";
                if (!File.Exists(pathsp))
                {

                }

                StreamReader sr = new StreamReader(pathsp);

                String rf = sr.ReadLine();
                String[] rfsplit;
                try
                {
                    String[] spearator = { ";" };
                    Int32 count = 2;
                    rfsplit = rf.Split(spearator, count, StringSplitOptions.RemoveEmptyEntries);

                    if ((txtUserName.Text) == rfsplit[0])
                    {
                        txtPassWord.Text = rfsplit[1];
                    }
                    else
                    {
                        txtPassWord.Text = "";
                    }


                }
                catch
                {

                }
                sr.Close();
            }
            catch
            {

            }


        }

        private void txtPassWord_Click(object sender, EventArgs e)
        {

        }


        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(13)))
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
