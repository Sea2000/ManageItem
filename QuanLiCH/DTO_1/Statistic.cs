using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class Statistic
    {
        private Account account;
        public Statistic(int statisticid, DateTime datepurchase, float itemreturn, float totalprice, int accountid, int numberbill)
        {
            this.StatisticID = statisticid;
            this.DatePurchase = datepurchase;
            this.ItemReturn = itemreturn;
            this.TotalPrice = totalprice;
           
            this.AccountID = accountid;
            this.NumberBill = numberbill;
     
        }

        public Statistic(DataRow row)
        {
            this.StatisticID = (int)row["statisticid"];
            this.DatePurchase =  (DateTime)row["datepurchase"];
           
            this.ItemReturn = (float)Convert.ToDouble(row["itemreturn"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());

            this.AccountID = (int)row["AccountID"];
            this.NumberBill = (int)row["numberbill"];
        }
        public int StatisticID { get; set; }
        public DateTime DatePurchase { get; set; }

        public float TotalPrice { get; set; }
        public float ItemReturn { get; set; }
        public int AccountID { get; set; }

        public int NumberBill { get; set; }

    }
}
