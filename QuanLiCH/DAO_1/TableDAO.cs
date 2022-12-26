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
    public class TableDAO
    {
        private static TableDAO instance; // Tạo singleton

        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
          private  set { TableDAO.instance = value; }
        }
        public static int TableWidth = 95;  //      Tạo chiều cao button
        public static int TableHeight = 95; //        Tạo chiều rộng Button
        private  TableDAO() { }

      
        public List<Items>  LoadFoodList() // Tạo đanh sách bàn ăn
        {
            List<Items> tableList = new List<Items>();
            string query1 = "Select * From Item";

            DataTable data = DataProvider.Instance.ExecuteQuery(query1);

            foreach (DataRow item in data.Rows)
            {
                Items table = new Items(item);
                tableList.Add(table);
            }

            return tableList;
        }



        public List<Items> GetListTabble()
        {
            List<Items> list = new List<Items>();

            string query = "Select * From Item";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Items table = new Items(item);
                list.Add(table);
            }

            return list;
        }

        //public List<Items> inserttableofItems()
        //{
        //    List<Items> list = new List<Items>();

        //    string query = "INSERT INTO Tablefood";

        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);

        //    foreach (DataRow item in data.Rows)
        //    {
        //        Items table = new Items(item);
        //        list.Add(table);
        //    }

        //    return list;
        //}

    }
    
}
