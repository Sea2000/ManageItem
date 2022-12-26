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
    public class BillTempDAO
    {
        private static BillTempDAO instance;

        public static BillTempDAO Instance
        {
            get { if (instance == null) instance = new BillTempDAO(); return BillTempDAO.instance; }
            private set { BillTempDAO.instance = value; }
        }
        private BillTempDAO() { }


        public List<BillTemp> GetlistBilltemp()
        {
            List<BillTemp> listBill = new List<BillTemp>();

            string query = "SELECT * from dbo.ShowItemTemp";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillTemp bill = new BillTemp(item);

                listBill.Add(bill);

            }

            return listBill;
        }
        public List<BillTemp> GetListBillTemp(int id)
        {
            List<BillTemp> listBillTemp = new List<BillTemp>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ShowItemTemp WHERE BillIdTemp = " + id);

            foreach (DataRow item in data.Rows)
            {
                BillTemp info = new BillTemp(item);
                listBillTemp.Add(info);
            }

            return listBillTemp;
        }
        public void InserBillInfo(int idBill,int idFood,int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });

        }
    }
}
