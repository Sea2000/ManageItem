using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using Microsoft.SqlServer.Management.Smo;
using QuanLiCH.DTO_1;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DAO_1
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }



        //public int GetUncheckBillIDByTableID(int id)
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ShowItemTemp WHERE ItemIDTemp = " + id);

        //    if (data.Rows.Count > 0)
        //    {
        //        Bill bill = new Bill(data.Rows[0]);
        //        return bill.BillId;
        //    }

        //    return -1;
        //}
        public int getitemshowtemp(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ShowItemTemp WHERE ItemIDTemp = " + id);

            if (data.Rows.Count > 0)
            {
                ShowItemTemp bill = new ShowItemTemp(data.Rows[0]);
                return bill.BillIdTemp;
            }

            return -1;
        }

       
        public int Deletedulieushowtemp()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Delete FROM dbo.ShowItemTemp");

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.BillId;
            }

            return -1;
        }

        //public int Deletedulieubillinfo()
        //{
        //    DataTable data = DataProvider.Instance.ExecuteQuery("Delete FROM dbo.Billinfo");
        //    if (data.Rows.Count > 0)
        //    {
        //        Bill bill = new Bill(data.Rows[0]);
        //        return bill.BillId;
        //    }

        //    return -1;
        //}
        public void deleteSLdamua(int id,float count)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Item SET QuantityItem = QuantityItem - " + count + " where ItemID = " + id);
        }
        public void PlusSLDamua(int id, float count)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Item SET QuantityItem = QuantityItem + " + count + " where ItemID = " + id);
            
        }
        public void UpdateStatistic(int idStatistic, float totalPrice,int numberbill, int idAccount)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_UpdateStatistic @StatisticID , @TotalPrice , @NumberBill , @AccountID", new object[] {idStatistic,totalPrice, numberbill,idAccount });
        }
       
        public void CheckOut(int itemidtemp,float quantitytemp,float pricetemp, float discounttemp, float totalPricebillltemp, int statisticsidtemp, int numberbill)
        {
          
            //string query = "UPDATE dbo.Bill SET ItemIDTemp = " + itemidtemp + ", SaleTimeTemp = " + saletimetemp + ",QuantityTemp ="+quantitytemp + ",PriceTemp = "+pricetemp + ",DiscountTemp ="+discounttemp+ ",TotalPriceBillTemp= "+totalPricebillltemp + ",StatisticIDTemp ="+statisticsidtemp+ " WHERE BillIdTemp = " + billidtemp;
            //DataProvider.Instance.ExecuteNonQuery(query);
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @ItemID , @Quantity , @Price , @Discount , @TotalPriceBill , @StatisticID , @NumberBill ", new object[] { itemidtemp, quantitytemp, pricetemp, discounttemp, totalPricebillltemp, statisticsidtemp, numberbill });


        }

        public void InserBillTemp(int ItemID, float totalPrice, float price, float count, int StatisticID)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBillTemp @ItemIDTemp , @TotalPriceBillTemp , @PriceTemp , @QuantityTemp , @StatisticIDTemp", new object[] { ItemID, totalPrice, price, count, StatisticID });

        }

        public void InserBill(int ItemID, float totalPrice, float price, float count, int StatisticID)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @ItemID , @TotalPriceBill , @Price , @Quantity, @StatisticID", new object[] { ItemID, totalPrice, price, count, StatisticID });

        }

        public void UpdateQuantityBillTemp(int id, float totalPrice, float quantity)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateBillTemp @ItemIDTemp , @TotalPriceBillTemp , @QuantityTemp ", new object[] { id, totalPrice,quantity });

        }

        public void InserBilladdsameitems(int id, float totalPrice)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @idTable , @totalPrice ", new object[] { id, totalPrice });

        }


        public DataTable GetlistStatistic()
        {
            return DataProvider.Instance.ExecuteQuery(" SELECT * from dbo.Statistic");
        }

        public DataTable GetListBillByDateAndPage(DateTime checkIn, DateTime checkOut,int pageNum)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDateAndPage @checkIn , @checkOut , @page ", new object[] { checkIn, checkOut,pageNum });
        }
        public int GetNumBillByDate(DateTime checkIn, DateTime checkOut)
        {
            return (int)DataProvider.Instance.ExecuteScalar("exec USP_GetNumBillByDate @checkIn , @checkOut ", new object[] { checkIn, checkOut });
        }
        public int Getnumberbill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(NumberBill)+1 FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public int GetMaxIDStatistic()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(StatisticID) +1 FROM dbo.Statistic");
            }
            catch
            {
                return 1;
            }
        }



    }

}
