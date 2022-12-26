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
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance 
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }


        public List<Menu> GetlistMenuByItems()
        {
            List<Menu> listMenu = new List<Menu>();
            //string query = "SELECT f.name, bi.count, f.price, f.price*bi.count AS totalPrice FROM dbo.BillInfo AS bi, dbo.Bill AS b, dbo.Item AS f WHERE bi.idBill = b.id AND bi.idFood = f.id AND b.status =0 AND f.id = " + id;
            string query = "SELECT f.NameItem, Sit.QuantityTemp, f.ExportPriceItem, f.ExportPriceItem * Sit.QuantityTemp AS totalPrice FROM dbo.ShowItemTemp AS Sit, dbo.Item AS f WHERE Sit.ItemIDTemp = f.ItemID ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
