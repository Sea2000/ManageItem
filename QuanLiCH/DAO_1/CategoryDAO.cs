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
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }
        public List<ItemCategory> GetlistCategory()
        {
            List<ItemCategory> list = new List<ItemCategory>();

            string query= "select * from ItemCategory";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                ItemCategory category = new ItemCategory(item);
                list.Add(category);

            }    
           return list;

        }
        public ItemCategory GetCategoryByID(int id)
        {
            ItemCategory category = null;

            List<ItemCategory> list = new List<ItemCategory>();

            string query = "select * from ItemCategory where id = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                 category = new ItemCategory(item);
                list.Add(category);

            }
            return category;
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT dbo.ItemCategory( NameCategory ) VALUES  ( N'{0}')", name );
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateCategory(int id,string name)
        {
            string query = string.Format("UPDATE dbo.ItemCategory SET NameCategory = N'{0}' WHERE id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteCategory(int id)
        {

            string query = string.Format("Delete ItemCategory where CategoryID = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

    }
}
