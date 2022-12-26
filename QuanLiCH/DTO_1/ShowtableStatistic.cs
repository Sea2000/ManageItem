using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class ShowtableStatistic
    {
        public ShowtableStatistic(int statisticid, DateTime datepurchase,string nameitem ,float quantity ,float exportpriceitem , float totalprice, float itemreturn, string displayname,  int numberbill)
        {
            this.StatisticID = statisticid;
            this.DatePurchase = datepurchase;
            this.NameItem = nameitem;
            this.Quantity = quantity;
            this.ExportPriceItem = exportpriceitem;
            this.TotalPrice = totalprice;
            this.ItemReturn = itemreturn;
            this.DisPlayName = displayname;

            this.NumberBill = numberbill;
          
        }
        public ShowtableStatistic(DataRow row)
        {
            this.StatisticID = (int)row["statisticid"];
            this.DatePurchase = (DateTime)row["datepurchase"];
            this.NameItem = row["nameitem"].ToString();
            this.Quantity = (float)Convert.ToDouble(row["quantity"].ToString());
            this.ExportPriceItem=(float)Convert.ToDouble(row["ExportPriceItem"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());
            this.ItemReturn = (float)Convert.ToDouble(row["itemreturn"].ToString());
            this.DisPlayName = row["displayname"].ToString();
            this.NumberBill = (int)row["numberbill"];
            
        }
        public int StatisticID { get; set; }
        public DateTime DatePurchase { get; set; }
        public string NameItem { get; set; }
        public float Quantity { get; set; }
        public float ExportPriceItem { get; set; }
        public float TotalPrice { get; set; }
        public float ItemReturn { get; set; }
        public string DisPlayName { get; set; }
        public int NumberBill { get; set; }

    }
}
