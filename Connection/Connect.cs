using System;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace QLyDiemSinhvien.Connection
{
    public class Connect
    {
        private SqlConnection conn;
        private string stringConection = "Data Source=VAN_DUC25\\SQLEXPRESS;Initial Catalog=QuanLyDiemSinhVien;Integrated Security=True";

        public Connect()
        {
            conn = new SqlConnection(stringConection);
        }

        public void OpenConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi kết nối SQL: " + ex.Message);  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi không xác định: " + ex.Message);  
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);  
            }
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
