using QuanLiCH.DTO_1;
using QuanLyQuanCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DAO_1
{
    class ItemReturnDAO
    {
        private static ItemReturnDAO instance;
        public static ItemReturnDAO Instance
        {
            get { if (instance == null) instance = new ItemReturnDAO(); return ItemReturnDAO.instance; }
            private set { ItemReturnDAO.instance = value; }
        }

        private ItemReturnDAO() { }

        public List<ItemReturn> GetListitem()
        {
            List<ItemReturn> list = new List<ItemReturn>();

            string query = "Select * from ItemReturn";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ItemReturn items = new ItemReturn(item);
                list.Add(items);
            }
            return list;
        }

        public void InserItemReturn(float quantity, int itemID, float totalprice)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertItemReturn @Quantity ,  @ItemID , @TotalPrice ", new object[] { quantity, itemID, totalprice });

        }
    }
}
