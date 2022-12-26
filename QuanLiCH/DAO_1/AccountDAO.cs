using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCH.DAO_1;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DTO_1
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            return result.Rows.Count > 0;
        }

        public bool Checkuserexist(string userName)
        {
            string query = string.Format("select * from dbo.Account  WHERE UserName = N'{0}'", userName);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;


        }




        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName,fullname, DisplayName,phone, Type FROM dbo.Account ");
        }

        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string name, string fullname, string displayName, string phone, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName,fullname, DisplayName,phone, Type ,password,UserRoleID )VALUES  ( N'{0}', N'{1}',N'{2}',N'{3}', {4},{5},{6})", name,fullname, displayName,phone, type,0, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string fullname, string displayName, string phone, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET fullname = N'{1}',DisplayName ='{2}',phone ='{3}', Type = {4} WHERE UserName = N'{0}'", name,fullname, displayName,phone, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName, @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set password = N'0' where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }

    
    
}
