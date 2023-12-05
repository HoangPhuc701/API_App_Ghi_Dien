namespace api_app_dien.Model
{
    public class GiaDienTu
    {
        public string MAGIADT;
        public DateTime THANGAPDUNG;
        public float CAODIEM;
        public float THAPDIEM;
        public float BINHTHUONG;
        public GiaDienTu() { }
        public GiaDienTu(string mAGIADT, DateTime tHANGAPDUNG, float cAODIEM, float tHAPDIEM, float bINHTHUONG)
        {
            MAGIADT = mAGIADT;
            THANGAPDUNG = tHANGAPDUNG;
            CAODIEM = cAODIEM;
            THAPDIEM = tHAPDIEM;
            BINHTHUONG = bINHTHUONG;
        }
    }
}
