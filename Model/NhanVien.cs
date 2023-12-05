namespace api_app_dien.Model
{
    public class NhanVien
    {
        public string MANV;
        public string TENNV;
        public string NGAYSINH;
        public string CHUCVU;
        public string MATKHAU;
        public int MAPHUONGXA;
        public NhanVien() { }
        public NhanVien(string mANV, string tENNV, string nGAYSINH, string cHUCVU, string mATKHAU, int mAPHUONGXA)
        {
            MANV = mANV;
            TENNV = tENNV;
            NGAYSINH = nGAYSINH;
            CHUCVU = cHUCVU;
            MATKHAU= mATKHAU;
            MAPHUONGXA = mAPHUONGXA;
        }
    }
}
