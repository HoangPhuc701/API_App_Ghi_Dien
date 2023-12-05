namespace api_app_dien.Model
{
    public class HinhThucSD
    {
        public string MAHINHTHUC;
        public string TENHINHTHUC;
        public HinhThucSD() { }
        public HinhThucSD(string mAHINHTHUC, string tENHINHTHUC)
        {
            MAHINHTHUC = mAHINHTHUC;
            TENHINHTHUC = tENHINHTHUC;
        }
    }
}
