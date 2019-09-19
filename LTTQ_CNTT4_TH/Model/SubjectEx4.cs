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