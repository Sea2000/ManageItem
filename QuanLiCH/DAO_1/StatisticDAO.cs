using Microsoft.SqlServer.Management.Sdk.Sfc;
using QuanLiCH.DTO_1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;
using DataProvider = QuanLyQuanCafe.DAO.DataProvider;
using Microsoft.SqlServer.Management.Smo;
using System.Windows;
using Statistic = QuanLiCH.DTO_1.Statistic;
using Microsoft.Identity.Client;
using System.Windows.Markup;
//using Statistic = QuanLiCH.DTO_1.Statistic;

namespace QuanLiCH.DAO_1
{
    public class StatisticDAO
    {
        private static StatisticDAO instance; // Tạo singleton

        public static StatisticDAO Instance
        {
            get { if (instance == null) instance = new StatisticDAO(); return StatisticDAO.instance; }
            private set { StatisticDAO.instance = value; }
        }

        private StatisticDAO() { }

        public List<Statistic> LoadlistStatistic()
        {
            List<Statistic> StatisticList = new List<Statistic>();
            string query = "SELECT st.StatisticID , st.DatePurchase , st.ItemReturn , st.TotalPrice ,st.AccountID, ac.DisplayName ,st.NumberBill FROM Statistic st, account ac WHERE ac.AccountID= st.AccountID"; 

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Statistic doanhthu = new Statistic(item);
           
                StatisticList.Add(doanhthu);
            }

            return StatisticList;
        }
        public int GetMaxIDStatistic()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(StatisticID) FROM dbo.Statistic");
            }
            catch
            {
                return 1;
            }
        }

        public void InsertIDstatistic(int idStatistic)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertIDstatistic @StatisticID ", new object[] { idStatistic });
        }


        public string LoadtotalStatistic()
        {
            float totalStatistic = 0;
            List<Statistic> Statisticlist = StatisticDAO.Instance.LoadlistStatistic();
            foreach (Statistic item in Statisticlist)
            {
                totalStatistic += item.TotalPrice;
            }
            return totalStatistic.ToString();
        }
        public List<Statistic> GetlistStatistic(DateTime checkIn, DateTime checkOut)
        {
            List<Statistic> TotalStatisticList = new List<Statistic>();
            string query = "select * from Statistic where DatePurchase >=" + @checkIn + " and DatePurchase<=" + @checkOut;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Statistic table = new Statistic(item);
                TotalStatisticList.Add(table);
            }

            return TotalStatisticList;

        }

    }
}
