using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{

    public class Table
    {
        private int iD;

        private string name;

        private int idcategory;

        private float price;

        private int quantity;



        public Table(int id, string name, int idcategory, float price, int quantity)
        {
            this.ID = id;
            this.Name = name;
            this.Idcategory = idcategory;
            this.Price = price;
            this.Quantity = quantity;

        }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Idcategory = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Quantity = (int)row["quantity"];


        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Idcategory { get => idcategory; set => idcategory = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

    }
}
