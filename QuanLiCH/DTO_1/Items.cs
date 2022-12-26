using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class Items
    {
        public Items(int itemiD, string nameitem, float entrypriceitem,float exportpriceitem, float quantityitem, string unit,string note,int categoryid)
        {
            this.ItemID = itemiD;
            this.NameItem = nameitem;
            this.EntryPriceItem = entrypriceitem;
            this.ExportPriceItem = exportpriceitem;
            this.QuantityItem = quantityitem;
            this.Unit = unit;
            this.Note = note;
            this.CategoryID = categoryid;
        }

        public Items(DataRow row)
        {
            this.ItemID = (int)row["itemiD"];
            this.NameItem = row["nameitem"].ToString();
            this.EntryPriceItem = (float)Convert.ToDouble(row["entrypriceitem"].ToString());
            this.ExportPriceItem = (float)Convert.ToDouble(row["exportpriceitem"].ToString());
            this.QuantityItem = (float)Convert.ToDouble(row["quantityitem"].ToString());
            this.Unit = row["unit"].ToString();
            this.Note = row["note"].ToString(); 
            this.CategoryID = (int)row["categoryid"];


        }

        public int ItemID { get; set; }
        public string NameItem { get; set; }
        public float EntryPriceItem { get; set; }
        public float ExportPriceItem { get; set; }
        public float QuantityItem { get; set; }
        public string Unit { get; set; }
        public string Note { get; set; }
        public int CategoryID { get; set; } 
    }
}
