using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_CNTT4_TH.Model
{
    public class SubjectEx4
    {
        public string TenMonHoc { get; set; }
        public int SoTin { get; set; }
        public string Diem { get; set; }

        public override string ToString()
        {
            return TenMonHoc + " ♥ " + SoTin + " ♥ " + Diem;
        }
    }
}