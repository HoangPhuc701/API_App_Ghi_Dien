namespace api_app_dien.Model
{
    public class DongHoDien
    {
        public string MADONGHODIEN;
        public string MAHINHTHUC;
        public string MACAPDIENAP;
        public string MANHA;
        public string MALOAIDH;
        public string DIACHI;
        public DongHoDien() { }
        public DongHoDien(string mADONGHODIEN, string mAHINHTHUC, string mACAPDIENAP, string mANHA, string mALOAIDH, string dIACHI)
        {
            MADONGHODIEN = mADONGHODIEN;
            MAHINHTHUC = mAHINHTHUC;
            MACAPDIENAP = mACAPDIENAP;
            MANHA = mANHA;
            MALOAIDH = mALOAIDH;
            DIACHI = dIACHI;
        }
    }
}
