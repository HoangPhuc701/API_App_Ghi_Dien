namespace api_app_dien.Model
{
    public class GiaCo
    {
        public string MAGIACO;
        public DateTime THANGAPDUNG;
        public float BAC1;
        public float BAC2;
        public float BAC3;
        public float BAC4;
        public float BAC5;
        public float BAC6;
        public GiaCo() { }
        public GiaCo(string mAGIACO, DateTime tHANGAPDUNG, float bAC1, float bAC2, float bAC3, float bAC4, float bAC5, float bAC6)
        {
            MAGIACO = mAGIACO;
            THANGAPDUNG = tHANGAPDUNG;
            BAC1 = bAC1;
            BAC2 = bAC2;
            BAC3 = bAC3;
            BAC4 = bAC4;
            BAC5 = bAC5;
            BAC6 = bAC6;
        }
    }
}
