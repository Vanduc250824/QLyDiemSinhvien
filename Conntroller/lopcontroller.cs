using QLyDiemSinhvien.Connection;
using QLyDiemSinhvien.Model;
using System;
using System.Data;
using System.Data.SqlClient;

namespace QLyDiemSinhvien.Controller
{
    internal class LopController
    {
        private readonly Connect conn;

        public LopController()
        {
            conn = new Connect();
        }
        //Lấy tất cả
        public List<lopmodel> GetAllLops()
        {
            string sql = "SELECT IdLop, TenLop FROM Lop";
            List <lopmodel> lopList = new List<lopmodel>();
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lopmodel lop = new lopmodel
                            (
                                reader.GetInt32(reader.GetOrdinal("IdLop")),
                                reader.GetString(reader.GetOrdinal("TenLop"))
                            );
                            lopList.Add(lop);
                        }
                    }
                }
                return lopList;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Thêm lớp mới
        public bool AddLop(lopmodel lop)
        {
            string sql = "INSERT INTO Lop (IdLop, TenLop) VALUES (@IdLop, @TenLop)";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdLop", lop.idLop);
                    cmd.Parameters.AddWithValue("@TenLop", lop.tenLop);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Sửa thông tin lớp
        public bool EditLop(lopmodel lop)
        {
            string sql = "UPDATE Lop SET TenLop = @TenLop WHERE IdLop = @IdLop";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdLop", lop.idLop);
                    cmd.Parameters.AddWithValue("@TenLop", lop.tenLop);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
        }

        // Xóa lớp
        public bool DeleteLop(int idLop)
        {
            string sql = "DELETE FROM Lop WHERE IdLop = @IdLop";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@IdLop", idLop);

                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                conn.CloseConnection();
            }
        }
    }
}

