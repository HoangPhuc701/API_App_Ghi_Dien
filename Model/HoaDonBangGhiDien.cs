namespace api_app_dien.Model
{
    public class HoaDonBangGhiDien
    {
        public string MABANGGHIDIEN;
        public string MAHOADON;
        public DateTime THANGGHI;
        public int CHISOCU;
        public int CHISOMOI;
        public int CHISOTIEUTHU;
        public double TIENDIEN;
        public double TIENTHUE;
        public double THANHTIEN;
        public string TRANGTHAITHANHTOAN;
        public string MADONGHODIEN;
        public HoaDonBangGhiDien() { }
        public HoaDonBangGhiDien(string mABANGGHIDIEN, string mAHOADON, DateTime tHANGGHI, int cHISOCU, int cHISOMOI, int cHISOTIEUTHU, double tIENDIEN, double tIENTHUE, double tHANHTIEN, string tRANGTHAITHANHTOAN, string mADONGHODIEN)
        {
            MABANGGHIDIEN = mABANGGHIDIEN;
            MAHOADON = mAHOADON;
            THANGGHI = tHANGGHI;
            CHISOCU = cHISOCU;
            CHISOMOI = cHISOMOI;
            CHISOTIEUTHU = cHISOTIEUTHU;
            TIENDIEN = tIENDIEN;
            TIENTHUE = tIENTHUE;
            THANHTIEN = tHANHTIEN;
            TRANGTHAITHANHTOAN = tRANGTHAITHANHTOAN;
            MADONGHODIEN = mADONGHODIEN;
        }
    }
}
