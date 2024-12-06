using QLyDiemSinhvien.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Conntroller
{
    internal class giangviencontroller
    {
        private SqlConnection conn;
        public giangviencontroller()
        {
            conn = new SqlConnection();
        }
        public bool addGiangvien(giangvienmodel gv)
        {
            
            return false;
        }
    }
}
