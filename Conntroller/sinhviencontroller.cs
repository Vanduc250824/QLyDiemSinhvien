using QLyDiemSinhvien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemSinhvien.Connection;
namespace QLyDiemSinhvien.Conntroller
{
    internal class sinhviencontroller
    {
        private Connect conn;
       
        public sinhviencontroller()
        {
            conn = new Connect();
            
        }
        //Lấy tất cả giá trị của bảng Sinh viên
        public List<sinhvienmodel> getAll()
        {
            List<sinhvienmodel> sinhvienList = new List<sinhvienmodel>();
            string query = "SELECT * FROM Sinhvien";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(query, conn.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sinhvienmodel sv = new sinhvienmodel
                            {
                                maSV = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                                tenSV = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                ngaysinh = !reader.IsDBNull(2) ? reader.GetDateTime(2) : DateTime.MinValue,
                                quequan = !reader.IsDBNull(3) ? reader.GetString(3) : string.Empty,
                                lophoc = !reader.IsDBNull(4) ? reader.GetString(4) : string.Empty
                            };
                            sinhvienList.Add(sv);
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
                 conn.CloseConnection();
            }
            return sinhvienList;
        }
        //Thêm sinh viên
        public bool addStudent(sinhvienmodel sv)
        {
            string sql = "INSERT INTO Sinhvien(TenSV, Ngaysinh, Quequan, Lophoc) VALUE(@tensv, @ngaysinh, @quequan, @lophoc)";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
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
                conn.CloseConnection();
            }
            return false;
        }
        //Sửa giảng viên
        public bool editStudent(sinhvienmodel sv)
        {
            string sql = "UPDATE Sinhvien SET TenSV = @tensv, Ngaysinh = @ngaysinh, Quequan = @quequan, Lophoc = @lophoc WHERE MaSV = @masv";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
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
                conn.CloseConnection();
            }
            return false;
        }
        //Xóa giảng viên
        public bool deleteStudent(int id) 
        {
            string sql = "DELETE FROM Sinhvien WHERE MaSV = @masv";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
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
                 conn.CloseConnection();
            }
            return false;
        }
    }
}
