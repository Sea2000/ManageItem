using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class BillTemp
    {
        public BillTemp( int itemidtemp, DateTime saletimetemp, float quantitytemp, float pricetemp, float discounttemp, float totalpricebilltemp, int statisticidtemp)
        {
            //this.BillIdTemp = billidtemp;
            this.ItemIdTemp = itemidtemp;
            this.SaleTimeTemp = saletimetemp;
            this.DiscountTemp = discounttemp;
            this.QuantityTemp = quantitytemp;
            this.PriceTemp = pricetemp;
            this.TotalPriceBillTemp = totalpricebilltemp;
            this.StatisticIdTemp = statisticidtemp;

        }
        public BillTemp(DataRow row)
        {
            //this.BillIdTemp = (int)row["BillIdTemp"];
            this.ItemIdTemp = (int)row["ItemIdTemp"];
            this.SaleTimeTemp = (DateTime)row["SaleTimeTemp"];

            if (row["discounttemp"].ToString() != "")
            {
                this.DiscountTemp = (float)Convert.ToDouble(row["discounttemp"].ToString());
            }

            this.QuantityTemp = (float)Convert.ToDouble(row["quantitytemp"].ToString());

            this.PriceTemp = (float)Convert.ToDouble(row["pricetemp"].ToString());

            this.TotalPriceBillTemp = (float)Convert.ToDouble(row["TotalPriceBillTemp"].ToString());

            this.StatisticIdTemp = (int)row["statisticidtemp"];


        }
       // private int billidtemp;
        private int itemidtemp;
        private DateTime saletimetemp;
        private float discounttemp;
        private float quantitytemp;
        private float pricetemp;
        private float totalpricebilltemp;
        private int statisticidtemp;


        //public int BillIdTemp
        //{
        //    get => billidtemp;
        //    set => billidtemp = value;
        //}

        public int ItemIdTemp
        {
            get => itemidtemp;
            set => itemidtemp = value;
        }

        public DateTime SaleTimeTemp
        {
            get => saletimetemp;
            set => saletimetemp = value;
        }

        public float DiscountTemp { get => discounttemp; set => discounttemp = value; }
        public float QuantityTemp
        {
            get => quantitytemp;
            set => quantitytemp = value;
        }
        public float PriceTemp
        {
            get => pricetemp;
            set => pricetemp = value;
        }
        public float TotalPriceBillTemp
        {
            get => totalpricebilltemp;
            set => totalpricebilltemp = value;
        }
        public int StatisticIdTemp
        {
            get => statisticidtemp;
            set => statisticidtemp = value;
        }

    }

}
