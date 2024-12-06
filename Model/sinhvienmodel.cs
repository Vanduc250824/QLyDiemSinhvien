using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    public class sinhvienmodel
    {
        public int maSV { get; set; }
        public string tenSV { get; set; }
        public DateTime ngaysinh { get; set; } 
        public string quequan { get; set; }
        public string lophoc { get; set; }

        public sinhvienmodel(int _maSV, string _tenSV, DateTime _ngaysinh, string _quequan, string _lophoc) 
        {
            this.maSV = _maSV;
            this.tenSV = _tenSV;
            this.ngaysinh = _ngaysinh;
            this.quequan = _quequan;
            this.lophoc = _lophoc;
        }
        public sinhvienmodel() { }
    }
}
