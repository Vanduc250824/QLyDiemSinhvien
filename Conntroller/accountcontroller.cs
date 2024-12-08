using QLyDiemSinhvien.Connection;
using QLyDiemSinhvien.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Conntroller
{
    internal class accountcontroller
    {
        private readonly Connect conn;

        public accountcontroller()
        {
            conn = new Connect();
        }
        // Thêm tài khoản mới
        public bool AddAccount(accountmodel account)
        {
            string sql = "INSERT INTO Account (TaiKhoan, MatKhau, ChucVu) VALUES (@TaiKhoan, @MatKhau, @ChucVu)";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = account.TaiKhoan;
                    cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = account.MatKhau;
                    cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = account.ChucVu;

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
        // Sửa thông tin tài khoản
        public bool EditAccount(accountmodel account)
        {
            string sql = "UPDATE Account SET MatKhau = @MatKhau, ChucVu = @ChucVu WHERE idAccount = @idAccount";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idAccount", account.idAccount);
                    cmd.Parameters.AddWithValue("@MatKhau", account.MatKhau);
                    cmd.Parameters.AddWithValue("@ChucVu", account.ChucVu);

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
        // Xóa tài khoản
        public bool DeleteAccount(int idAccount)
        {
            string sql = "DELETE FROM Account WHERE idAccount = @idAccount";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@idAccount", idAccount);

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
        // Kiểm tra tài khoản tồn tại
        public bool IsAccountExist(string taiKhoan)
        {
            string sql = "SELECT COUNT(*) FROM Account WHERE TaiKhoan = @TaiKhoan";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
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
        // Kiểm tra tài khoản và mật khẩu
        public bool CheckAccountLogin(string taiKhoan, string matKhau)
        {
            string sql = "SELECT COUNT(*) FROM Account WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    int count = (int)cmd.ExecuteScalar(); 
                    return count > 0; 
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

        // Lấy role của tài khoản
        public string GetRole(string taiKhoan)
        {
            string sql = "SELECT ChucVu FROM Account WHERE TaiKhoan = @TaiKhoan";
            try
            {
                conn.OpenConnection();
                using (SqlCommand cmd = new SqlCommand(sql, conn.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
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
    }
}
