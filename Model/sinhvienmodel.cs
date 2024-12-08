using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    public class sinhvienmodel
    {
        
        public int MaSV { get; set; }
        public string TenSV { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string LopHoc { get; set; }  
        
        public sinhvienmodel(int _maSV, string _tenSV, DateTime _ngaysinh, string _quequan, string _lophoc) 
        {
            this.MaSV = _maSV;
            this.TenSV = _tenSV;
            this.NgaySinh = _ngaysinh;
            this.QueQuan = _quequan;
            this.LopHoc = _lophoc;
        }
        public sinhvienmodel() { }
    }
}
