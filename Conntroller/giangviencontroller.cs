﻿using QLyDiemSinhvien.Model;
using System.Data.SqlClient;
using QLyDiemSinhvien.Connection;

namespace QLyDiemSinhvien.Conntroller
{
    internal class giangviencontroller
    {
        private Connect conn;
        public giangviencontroller()
        {
            conn = new Connect();
        }
        //Lấy tất cả dử liệu của bảng giảng viên
        public List<giangvienmodel> getAll()
        {
            List<giangvienmodel> giangvienList = new List<giangvienmodel>();
            string sql = "SELECT idGiangVien, HoTen, Email, Khoa FROM Giangvien";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            giangvienmodel gv = new giangvienmodel
                            {
                                maGV = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                                tenGV = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                email = !reader.IsDBNull(2) ? reader.GetString(2) : string.Empty,
                                khoa = !reader.IsDBNull(3) ? reader.GetString(3) : string.Empty
                            };
                            giangvienList.Add(gv);
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
            return giangvienList;
        }
        //Thêm giảng viên
        public bool addGiangvien(giangvienmodel gv)
        {
            string sql = "INSERT INTO GiangVien(Hoten, Email, Khoa) VALUE (@hoten, @email, @khoa)";

            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@hoten", gv.tenGV);
                    command.Parameters.AddWithValue("@email", gv.email);
                    command.Parameters.AddWithValue("@khoa", gv.khoa);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
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
        //Sửa giảng vien 
        public bool editGiangvien(giangvienmodel gv)
        {
            string sql = "UPDATE Giangvien SET HoTen = @hoten,  Email = @email, Khoa = @khoa WHERE idGiangvien = @idgiangvien";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@hoten", gv.tenGV);
                    command.Parameters.AddWithValue("@email", gv.email);
                    command.Parameters.AddWithValue("@khoa", gv.khoa);
                    command.Parameters.AddWithValue("@idGiangvien", gv.maGV);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
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
        public bool deleteGiangvien(int id)
        {
            string sql = "DETELE FROM Giangvien WHERE idGiangvien = @id";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
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
