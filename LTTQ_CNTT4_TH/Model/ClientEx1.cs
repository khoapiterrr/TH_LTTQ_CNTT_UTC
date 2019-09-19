using System;

namespace LTTQ_CNTT4_TH.Model
{
    public class ClientEx1
    {
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayChot { get; set; }
        public int ThangTruoc { get; set; }
        public int ThangNay { get; set; }

        /// <summary>
        /// Tính tiền điện
        /// </summary>
        /// <returns></returns>
        public string GetMoney()
        {
            if (ThangNay <= 50)
            {
                return ((ThangNay * 100) * 1.1).ToString();
            }
            else if (ThangNay <= 100)
            {
                return ((50 * 100 + (ThangNay - 50) * 200) * 1.1).ToString();
            }
            else if (ThangNay <= 200)
            {
                return ((50 * 100 + 50 * 200 + (ThangNay - 100) * 300) * 1.1).ToString();
            }
            return ((50 * 100 + 50 * 200 + 100 * 300 + (ThangNay - 200) * 400) * 1.1).ToString();
        }

        public override string ToString()
        {
            return $"{MaKH} | {TenKH} | {DiaChi} | {NgayChot.ToString("dd/MM/yyyy")} | {ThangTruoc} | {ThangNay} | {GetMoney()}";
        }
    }
}