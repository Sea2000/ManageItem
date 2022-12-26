using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCH.DTO_1;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DAO_1
{
   public class ItemsDAO
    {
        private static ItemsDAO instance;

        public static ItemsDAO Instance
        {
            get { if (instance == null) instance = new ItemsDAO(); return ItemsDAO.instance; }
            private set { ItemsDAO.instance = value; }
        }

        private ItemsDAO() { }

        public List<Items> GetitemByCategoryID(int id)
        {
            List<Items> list = new List<Items>();

            string query = "select * from Item where CategoryID = " + id ;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                list.Add(items);
            }

            return list;
        }

        public List<Items> GetitemByID(int id)
        {
            List<Items> list = new List<Items>();

            string query = "select * from Item where ItemID = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                list.Add(items);
            }

            return list;
        }

        public List<Items> GetListitem()
        {
            List<Items> list = new List<Items>();

            string query = "Select * from Item";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                list.Add(items);
            }

            return list;
        }
        public List<Items> SearchitemByName(string name)
        {
            List<Items> list = new List<Items>();

            string query = string.Format("SELECT * FROM dbo.Item WHERE NameItem LIKE N'%' +(N'{0}') + '%'", name);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Items items = new Items(item);
                list.Add(items);
            }
            return list;
        }
        public bool Insertitem( string name,float priceentry, float priceexport, int quantity, string unit,string note, int idcategory)
        {
            string query = string.Format("INSERT dbo.Item (NameItem, CategoryID, EntryPriceItem,ExportPriceItem , QuantityItem ,unit,Note )VALUES  ( N'{0}', {1}, {2},{3},{4},N'{5}',N'{6}')", name, idcategory, priceentry,priceexport, quantity,unit,note);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool Updateitem(int iditem,string name, int idcategory, float priceentry, float priceexport, int quantity, string unit,string note)
        {
            string query = string.Format("UPDATE dbo.Item SET NameItem = N'{0}', CategoryID = {1}, EntryPriceItem = {2}, ExportPriceItem= {3},QuantityItem ={4} ,unit =N'{5}',note =N'{6}' WHERE ItemID = {7}", name, idcategory, priceentry,priceexport,quantity,unit,note, iditem);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool Deleteitem(int iditem)
        {
           

            string query = string.Format("Delete Item where ItemID = {0}", iditem);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public void InsertquantityItems(float quantity, int itemID)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Item SET QuantityItem =  QuantityItem + " + quantity + " WHERE ItemID = " + itemID);
        }
    }
}
