using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace QuanLiCH.DTO_1
{
  public class Bill
    {
        public Bill(int billid,int itemid ,DateTime saletime,int quantity,float price,float discount,float totalprice,int statisticid, int numberbill)
        {
            this.BillId = billid;
            this.ItemId = itemid;
            this.SaleTime = saletime;
            this.Discount = discount;
            this.Quantity = quantity;
            this.Price = price;
            this.TotalPrice = totalprice;
            this.StatisticId = statisticid;
            this.Numberbill = numberbill;
            

        }
        public Bill(DataRow row)
        {
            this.BillId = (int)row["BillID"];
            this.ItemId = (int)row["itemid"];
            this.SaleTime = (DateTime)row["saletime"];

            if (row["discount"].ToString() != "")
            {
                this.Discount = (float)Convert.ToDouble(row["discount"].ToString());
            }

            this.Quantity = (int)row["quantity"];

            this.Price = (float)Convert.ToDouble(row["price"].ToString());

            this.TotalPrice = (float)Convert.ToDouble(row["totalprice"].ToString());

            this.StatisticId = (int)row["statisticid"];

            this.Numberbill = (int)row["NumberBill"];


        }
        private int billid;
        private int itemid;
        private DateTime saletime;
        private float discount;
        private int quantity;
        private float price;
        private float totalprice;
        private int statisticid;
        private int numberbill;


        public int BillId
        {
            get => billid;
            set => billid = value; 
        }

        public int ItemId
        {
            get => itemid;
            set => itemid = value;
        }

        public DateTime SaleTime 
        { 
            get => saletime; 
            set => saletime = value;
        }

        public float Discount { get => discount; set => discount = value; }
        public int Quantity
        {
            get => quantity;
            set => quantity = value;
        }
        public float Price
        {
            get => price;
            set => price = value;
        }
        public float TotalPrice
        {
            get => totalprice;
            set => totalprice = value;
        }
        public int StatisticId
        {
            get => statisticid;
            set => statisticid = value;
        }
        public int Numberbill
        {
            get => numberbill;
            set => numberbill = value;
        }

    }
}
