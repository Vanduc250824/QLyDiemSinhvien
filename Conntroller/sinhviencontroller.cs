using QLyDiemSinhvien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Conntroller
{
    internal class sinhviencontroller
    {
        private SqlConnection conn;
        
        public sinhviencontroller()
        {
            conn = new SqlConnection();
            
        }
        public List<sinhvienmodel> getAll()
        {
            List<sinhvienmodel> sinhvienList = new List<sinhvienmodel>();
            string query = "SELECT * FROM Sinhvien";
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sinhvienmodel sv = new sinhvienmodel
                            {
                                maSV = reader["MaSV"] != DBNull.Value ? Convert.ToInt32(reader["MaSV"]) : 0,
                                tenSV = reader["TenSV"] != DBNull.Value ? reader["MaSV"].ToString() : string.Empty,
                                ngaysinh = reader["Ngaysinh"] != DBNull.Value ? Convert.ToDateTime(reader["Ngaysinh"]) : DateTime.MinValue,
                                quequan = reader["Quequan"] != DBNull.Value ? reader["Quequan"].ToString() : string.Empty,
                                lophoc = reader["Lophoc"] != DBNull.Value ? reader["Lophoc"].ToString() : string.Empty
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) 
                {
                    conn.Close();
                } 
            }
            return sinhvienList;
        }
        public bool addStudent(sinhvienmodel sv)
        {
            string sql = "INSERT INTO Sinhvien(MaSV, TenSV, Ngaysinh, Quequan, Lophoc) VALUE(@masv, @tensv, @ngaysinh, @quequan, @lophoc)";
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@masv", sv.maSV);
                    command.Parameters.AddWithValue("@tensv", sv.tenSV);
                    command.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                    command.Parameters.AddWithValue("@quequan", sv.quequan);
                    command.Parameters.AddWithValue("@lophoc", sv.lophoc);
                    
                    int rowAffected = command.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool editStudent(sinhvienmodel sv)
        {
            string sql = "UPDATE Sinhvien SET TenSV = @tensv, Ngaysinh = @ngaysinh, Quequan = @quequan, Lophoc = @lophoc WHERE MaSV = @masv";
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@masv", sv.maSV);
                    command.Parameters.AddWithValue("@tensv", sv.tenSV);
                    command.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                    command.Parameters.AddWithValue("@quequan", sv.quequan);
                    command.Parameters.AddWithValue("@lophoc", sv.lophoc);

                    int rowAffected = command.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
        public bool deleteStudent(int id) 
        {
            string sql = "DELETE FROM MaSV = @masv";
            try
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    command.Parameters.AddWithValue("@masv", id);

                    int rowAffected = command.ExecuteNonQuery();
                    return rowAffected > 0;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return false;
        }
    }
}
