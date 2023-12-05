namespace api_app_dien.Model
{
    public class LoaiDHDienTu
    {
        public string MADHDIENTU;
        public string TENDHDIENTU;
        public string MAGIADT;
        public string MALOAIDH;
        public LoaiDHDienTu() { }
        public LoaiDHDienTu(string mADHDIENTU, string tENDHDIENTU, string mAGIADT,string mALOAIDH)
        {
            MADHDIENTU= mADHDIENTU;
            TENDHDIENTU= tENDHDIENTU;
            MAGIADT= mAGIADT;
            MALOAIDH= mALOAIDH;
        }
    }
}
