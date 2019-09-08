using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTQ_CNTT4_TH.Model
{
    public class ClientEx3
    {
        public string TenKH { get; set; }

        /// <summary>
        /// 1. cả ngày 200$
        /// 2. nửa ngày 100$
        /// </summary>
        public int ThoiGianThue { get; set; }

        /// <summary>
        /// 1. coca 0.5$
        /// 2. pepsi 0.8$
        /// 3. seven up 1$
        /// </summary>
        public int DoUong { get; set; }

        public int SoLuong { get; set; }

        public double GetFoodMoney()
        {
            if (DoUong == 1)
                return 0.5 * SoLuong;
            else if (DoUong == 2)
                return 0.8 * SoLuong;
            else if (DoUong == 3)
                return 1 * SoLuong;
            return 0;
        }

        public double GetTotalMoney()
        {
            return ThoiGianThue == 1 ? 200 + GetFoodMoney() : 100 + GetFoodMoney();
        }

        public override string ToString()
        {
            return $"{TenKH} | {(ThoiGianThue == 1 ? "Cả ngày 200$" : "Nửa ngày 100$")} | Đồ uống {GetFoodMoney()}$ | Tổng {GetTotalMoney()}";
        }
    }
}