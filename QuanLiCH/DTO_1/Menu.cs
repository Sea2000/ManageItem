using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class Menu
    {
        public Menu(string itemName,float quantity, float price,float totalPrice = 0)
        {
            this.ItemName = itemName;
            this.Quantity = quantity; 
            this.Price = price; 
            this.TotalPrice = totalPrice;   
        }
        public Menu(DataRow row)
        {
            this.ItemName = row["NameItem"].ToString();
            this.Quantity = (float)Convert.ToDouble(row["QuantityTemp"].ToString());
            this.Price = (float)Convert.ToDouble(row["ExportPriceItem"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;

        private float price;

        private float quantity;

        private string itemName;

        public string ItemName
        {
            get => itemName; 
            set => itemName = value;
        }
        public float Quantity
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
            get => totalPrice;
            set => totalPrice = value; 
        }
    }
}
