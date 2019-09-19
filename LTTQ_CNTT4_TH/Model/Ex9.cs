namespace LTTQ_CNTT4_TH.Model
{
    public class Ex9
    {
        public string TenSach { get; set; }
        public long Gia { get; set; }
        public int SoLuong { get; set; }
        public float GiamGia { get; set; }

        public double ThanhTien()
        {
            return (SoLuong * Gia * (1 - GiamGia / 100));
        }

        public override string ToString()
        {
            return $"{TenSach}, {SoLuong} - {ThanhTien()}";
        }
    }
}