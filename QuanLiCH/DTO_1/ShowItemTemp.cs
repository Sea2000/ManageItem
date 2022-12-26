using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class ShowItemTemp
    {
        public ShowItemTemp( int billidtemp, int itemidtemp, DateTime saletimetemp, int quantitytemp, float pricetemp, float discounttemp, float totalpricetemp, int statisticidtemp)
        {
            this.BillIdTemp = billidtemp;
            this.ItemIdTemp = itemidtemp;
            this.SaleTimeTemp = saletimetemp;
            this.DiscountTemp = discounttemp;
            this.QuantityTemp = quantitytemp;
            this.PriceTemp = pricetemp;
            this.TotalPriceTemp = totalpricetemp;
            this.StatisticIdTemp = statisticidtemp;

        }
        public ShowItemTemp(DataRow row)
        {
            this.BillIdTemp = (int)row["billidtemp"];
            this.ItemIdTemp = (int)row["ItemIDTemp"];
            this.SaleTimeTemp = (DateTime)row["SaleTimeTemp"];

            if (row["DiscountTemp"].ToString() != "")
            {
                this.DiscountTemp = (float)Convert.ToDouble(row["DiscountTemp"].ToString());
            }

            this.QuantityTemp = (float)Convert.ToDouble(row["QuantityTemp"].ToString());

            this.PriceTemp = (float)Convert.ToDouble(row["PriceTemp"].ToString());

            this.TotalPriceTemp = (float)Convert.ToDouble(row["TotalPriceBillTemp"].ToString());

            this.StatisticIdTemp = (int)row["StatisticIDTemp"];


        }
        private int billidtemp;
        private int itemid;
        private DateTime saletime;
        private float discount;
        private float quantity;
        private float price;
        private float totalprice;
        private int statisticid;


        public int BillIdTemp
        {
            get => billidtemp;
            set => billidtemp = value;
        }

        public int ItemIdTemp
        {
            get => itemid;
            set => itemid = value;
        }

        public DateTime SaleTimeTemp
        {
            get => saletime;
            set => saletime = value;
        }

        public float DiscountTemp { get => discount; set => discount = value; }
        public float QuantityTemp
        {
            get => quantity;
            set => quantity = value;
        }
        public float PriceTemp
        {
            get => price;
            set => price = value;
        }
        public float TotalPriceTemp
        {
            get => totalprice;
            set => totalprice = value;
        }
        public int StatisticIdTemp
        {
            get => statisticid;
            set => statisticid = value;
        }

    }
}
