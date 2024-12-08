using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    internal class monhocmodel
    {
        public int id { get; set; }
        public string tenMH { get; set; }
        public int soTC { get; set; }

        public monhocmodel() { }
        public monhocmodel(int _id, string _tenMH, int _soTC)
        {
            this.id = _id;
            this.tenMH = _tenMH;
            this.soTC = _soTC;
        }
    }
}
