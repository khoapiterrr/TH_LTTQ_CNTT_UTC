using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_CNTT4_TH.Model
{
    public class Ex14
    {
        public string HoTen { get; set; }
        public string Nganh { get; set; }
        public string Khoa { get; set; }
        public List<string> Sachs { get; set; }

        public Ex14()
        {
            Sachs = new List<string>();
        }

        public override string ToString()
        {
            return $" {HoTen} - {Nganh} - K{Khoa} - ĐK: {string.Join(",", Sachs)}.";
        }
    }
}