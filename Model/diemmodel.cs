using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLyDiemSinhvien.Model
{
    internal class diemmodel
    {
        public int iddiem { get; set; }
        public int idsv { get; set; }
        public int idmonhoc { get; set; }
        public float diemso { get; set; }
        
        public diemmodel() { }
        public diemmodel(int iddiem, int idsv, int idmonhoc, float diemso)
        {
            this.iddiem = iddiem;
            this.idsv = idsv;
            this.idmonhoc = idmonhoc;
            this.diemso = diemso;
        }
    }
}
