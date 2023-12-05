namespace api_app_dien.Model
{
    public class KhachHang
    {
        public string MAKH;
        public string TenKH;
        public int SDT;
        public string MATKHAU;
        public string MANHA;
        public KhachHang() { }
        public KhachHang(string mAKH, string tenKH, int sDT, string mATKHAU, string mANHA)
        {
            MAKH = mAKH;
            TenKH = tenKH;
            SDT = sDT;
            MATKHAU = mATKHAU;
            MANHA = mANHA;
        }
    }
}
