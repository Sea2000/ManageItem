using QuanLiCH.DTO_1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DAO;

namespace QuanLiCH.DAO_1
{
    public class ShowtableStatisticDAO
    {
        private static ShowtableStatisticDAO instance;

        public static ShowtableStatisticDAO Instance
        {
            get { if (instance == null) instance = new ShowtableStatisticDAO(); return ShowtableStatisticDAO.instance; }
            private set { ShowtableStatisticDAO.instance = value; }
        }
        private ShowtableStatisticDAO() { }


        public List<ShowtableStatistic> getliststatistics()
        {

            List<ShowtableStatistic> ListStatistic = new List<ShowtableStatistic>();
            string query = "SELECT st.StatisticID , st.DatePurchase , it.NameItem , b.Quantity ,it.ExportPriceItem , st.TotalPrice , st.ItemReturn , ac.DisplayName , st.NumberBill FROM Statistic st, account ac , bill b ,Item it WHERE ac.AccountID = st.AccountID  and st.StatisticID = b.StatisticID and b.ItemID = it.ItemID";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ShowtableStatistic doanhthu = new ShowtableStatistic(item);

                ListStatistic.Add(doanhthu);
            }

            return ListStatistic;
        }

        //search by date
        public DataTable GetListStatisticByDate(DateTime datefrom, DateTime dateto)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListStatisticByDate @timefrom , @timeto ", new object[] { datefrom, dateto });
        }

        //search by nameitem and date
        public DataTable GetListStatisticByNameitemandDate(DateTime datefrom, DateTime dateto,string nameitem)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListStatisticByNameItemandDate @timefrom , @timeto , @nameitem ", new object[] { datefrom, dateto ,nameitem });
        }
        //search by nameitem and date and selelr
        public DataTable GetListStatisticByNameitemandDateandseller(DateTime datefrom, DateTime dateto, string nameitem,string seller)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListStatisticByNameItemandDateandseller @timefrom , @timeto , @nameitem , @seller ", new object[] { datefrom, dateto, nameitem,seller });
        }

        public DataTable GetListStatisticByseller(DateTime datefrom, DateTime dateto, string seller)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListStatisticByseller @timefrom , @timeto , @seller ", new object[] { datefrom, dateto, seller });
        }
        
    }

}
