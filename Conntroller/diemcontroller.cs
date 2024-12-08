using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLyDiemSinhvien.Connection;
using QLyDiemSinhvien.Model;

namespace QLyDiemSinhvien.Conntroller
{
    internal class diemcontroller
    {
        private Connect conn;
        public diemcontroller()
        {
            conn = new Connect();
        }
        public List<diemmodel> getAll()
        {
            List<diemmodel> diemLists = new List<diemmodel>();
            string sql = "SELECT * FROM Diem";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            diemmodel diem = new diemmodel
                            {
                                iddiem = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                                idsv = !reader.IsDBNull(1) ? reader.GetInt32(1) : 0,
                                diemso = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0,
                                idmonhoc = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0        
                            };
                            diemLists.Add(diem);
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
            return diemLists;
        }
        public bool addDiem(diemmodel diem)
        {
            string sql = "INSERT INTO Diem(idSinhVien, idMonhoc, DiemSo) VALUES (@idsinhvien, @idmonhoc, @diem)";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@idsinhvien", diem.idsv);
                    command.Parameters.AddWithValue("@idmonhoc", diem.idmonhoc);
                    command.Parameters.AddWithValue("@diem", diem.diemso);

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
        public bool editDiem(diemmodel diem) 
        {
            string sql = "UPDATE Diem SET DiemSo = @diemso WHERE idDiem = @iddiem";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql,conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@diemso", diem.diemso);
                    command.Parameters.AddWithValue("@iddiem", diem.iddiem);
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
        public bool deleteDiem(int id)
        {
            string sql = "DELETE FROM Diem WHERE idDiem = @iddiem";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@iddiem", id);

                    int rowAffected = command.ExecuteNonQuery();
                    return rowAffected > 0;
                }    
            }
            catch (SqlException ex)
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
