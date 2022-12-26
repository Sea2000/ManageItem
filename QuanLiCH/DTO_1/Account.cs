using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class Account
    {
        public Account(int accountID, string username , string fullname , string displayName ,string phone ,string password ,int type , int userroleID)
        {           

            this.AccountID = accountID;
            this.UserName = username;
            this.FullName = fullname;
            this.DisplayName = displayName;
            this.Phone = phone;
            this.PassWord = password;
            this.Type = type;
            this.UserroleID = userroleID;

        }

        public Account(DataRow row)
        {
            this.AccountID = (int)row["accountID"];
            this.UserName = row["username"].ToString();
            this.FullName = row["fullname"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Phone = row["phone"].ToString();
            this.PassWord = row["password"].ToString();
            this.Type = (int)row["type"];
            this.UserroleID = (int)row["userroleID"];
        }


        private int accountID;
        private string username;
        private string fullname;
        private string displayName;
        private string phone;

        private string password;
        private int type;
        private int userroleID;

        public int AccountID
        {
            get => accountID;
            set => accountID = value;
        }

        public string UserName
        {
            get => username;
            set => username = value;
        }
        public string FullName
        {
            get => fullname;
            set => fullname = value;
        }
        public string DisplayName
        {
            get => displayName;
            set => displayName = value;
        }
        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string PassWord
        {
            get => password;
            set => password = value;
        }

        public int Type
        {
            get => type;
            set => type = value;
        }

        public int UserroleID
        {
            get => userroleID;
            set => userroleID = value;
        }
    }
}
