using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    public class giangvienmodel
    {
        public int maGV { get; set; }
        public string tenGV { get; set; }
        public string email { get; set; }
        public string khoa { get; set; }
        public giangvienmodel() { }
        public giangvienmodel(int _magv, string _tengv, string _email, string _khoa)
        {
            this.maGV = _magv;
            this.tenGV = _tengv;
            this.email = _email; 
            this.khoa = _khoa;
        }
    }
}
