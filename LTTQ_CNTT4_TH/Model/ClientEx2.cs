using System;

namespace LTTQ_CNTT4_TH.Model
{
    public class ClientEx2
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long Money { get; set; }
        public DateTime NgayGui { get; set; }
        public int ThoiGianGui { get; set; }
        public int Loai { get; set; }

        public override string ToString()
        {
            return $"{this.Id} |  {this.Name}  |  {this.Address}  |  {this.Money}  |  {this.NgayGui.ToString("dd/MM/yyyy")}  |  {this.ThoiGianGui} tháng |  {GetMoney()} ";
        }

        public double GetMoney()
        {
            if (Loai == 1)
            {
                switch (ThoiGianGui)
                {
                    case 1:
                        return this.Money * 0.06;

                    case 3:
                        return this.Money * 0.07;

                    case 6:
                        return this.Money * 0.08;

                    case 12:
                        return this.Money * 0.09;

                    default:
                        return 0;
                }
            }
            else if (Loai == 2)
            {
                switch (ThoiGianGui)
                {
                    case 1:
                        return this.Money * 0.07;

                    case 3:
                        return this.Money * 0.08;

                    case 6:
                        return this.Money * 0.09;

                    case 12:
                        return this.Money * 0.1;

                    default:
                        return 0;
                }
            }
            return 0;
        }
    }
}