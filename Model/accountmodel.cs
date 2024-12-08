using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    internal class accountmodel
    {
        public int idAccount { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string ChucVu { get; set; } 
        
        public accountmodel(int _id, string _taiKhoan, string _matKhau, string _chucVu)
        {
            idAccount = _id;
            TaiKhoan = _taiKhoan;
            MatKhau = _matKhau;
            ChucVu = _chucVu;
        }
        
    }
}
