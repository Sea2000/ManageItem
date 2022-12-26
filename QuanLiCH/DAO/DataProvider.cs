using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCH.DAO
{
    internal class DataProvider
    {
        private string connectionSTr = "Data Source=.\SQLEXPRESS2K19;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";
        public  DataTable ExecuteQuery(string query)
        {
            SqlConection connection = new SqlConnection(connectionSTr); // kết nối data tới sever

            
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);
            connection.Close();

            
        }

    }

}
