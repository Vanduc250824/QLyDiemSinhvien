using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    internal class lopmodel
    {
        public int idLop {  get; set; }
        public string tenLop { get; set; }
    
        public lopmodel(int idLop, string tenLop)
        {
            this.idLop = idLop;
            this.tenLop = tenLop;
        }
    }
}
