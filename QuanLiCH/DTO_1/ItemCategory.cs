using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DTO_1
{
    public class ItemCategory
    {
        private int categoryid;

        private string namecategory;

        public ItemCategory(int categoryid, string namecategory)
        {
            this.CategoryID = categoryid;
            this.NameCategory = namecategory;
        }
        public ItemCategory(DataRow row)
        {

            this.CategoryID = (int)row["categoryid"];
            this.NameCategory = row["namecategory"].ToString();
        }

        public int CategoryID { get => categoryid; set => categoryid = value; }
        public string NameCategory { get => namecategory; set => namecategory = value; }
    }
}
