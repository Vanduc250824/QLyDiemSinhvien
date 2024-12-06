using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLyDiemSinhvien.Connection
{
    public class Connect
    {
        private SqlConnection conn;
        private string stringConection = "Data Source=VAN_DUC25\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        public Connect()
        {
            conn = new SqlConnection(stringConection);
        }
        public void OpenConection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public void CloseConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
        public SqlConnection GetConnection() {
            return conn;
        } 
    }
}
