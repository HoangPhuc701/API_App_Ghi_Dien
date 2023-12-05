namespace api_app_dien.Model
{
    public class Nha
    {
        public string MANHA;
        public string SONHA;
        public string TENDUONG;
        public string TENCHUHO;
        public int MAPHUONGXA;

        public Nha() { }

        public Nha(string mANHA, string sONHA, string tENDUONG,string tENCHUHO, int mAPHUONGXA)
        {
            MANHA = mANHA;
            SONHA = sONHA;
            TENDUONG = tENDUONG;
            TENCHUHO = tENCHUHO;
            MAPHUONGXA = mAPHUONGXA;
        }
    }
}
