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

    internal class monhoccontroller
    {
        private Connect conn;
        public monhoccontroller()
        {
            conn = new Connect();
        }
        public List<monhocmodel> getAll()
        {
            List<monhocmodel> monhocLists = new List<monhocmodel>();
            string sql = "SELECT * FROM Monhoc";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            monhocmodel mh = new monhocmodel()
                            {
                                id = !reader.IsDBNull(0) ? reader.GetInt32(0) : 0,
                                tenMH = !reader.IsDBNull(1) ? reader.GetString(1) : string.Empty,
                                soTC = !reader.IsDBNull(2) ? reader.GetInt32(2) : 0
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
                conn.CloseConnection();
            }
            return monhocLists;
        }
        public bool addMonhoc(monhocmodel mh)
        {
            string sql = "INSERT INTO Monhoc( tenMon, TC) VALUE(@idmon, @tenmon, @tc)";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand(sql, conn.GetConnection()))
                {
                    command.Parameters.AddWithValue("@tenmon", mh.tenMH);
                    command.Parameters.AddWithValue("@tc", mh.soTC);

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
        public bool editMonhoc(monhocmodel mh)
        {
            string sql = "UPDATE Monhoc SET  tenMon = @tenmon, TC = @tc WHERE idMonhoc = @idmonhoc";
            try
            {
                conn.OpenConnection();
                using (SqlCommand command = new SqlCommand())
                {

                    command.Parameters.AddWithValue("@tenmon", mh.tenMH);
                    command.Parameters.AddWithValue("@tc", mh.soTC);
                    command.Parameters.AddWithValue("@idmonhoc", mh.id);

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
        public bool deleteMonhoc(int id)
        {
            string sql = "DELETE FROM Monhoc WHERE idMonhoc = @id";
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
