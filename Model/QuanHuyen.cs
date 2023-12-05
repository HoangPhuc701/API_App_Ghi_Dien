namespace api_app_dien.Model
{
    public class QuanHuyen
    {
        public int MAQUANHUYEN;
        public int MATINHTP;
        public string TENQUANHUYEN;

        public QuanHuyen() { }
        public QuanHuyen(int mAQUANHUYEN,int mATINHTP, string tENQUANHUYEN)
        {
            MAQUANHUYEN= mAQUANHUYEN;
            MATINHTP= mATINHTP;
            TENQUANHUYEN = tENQUANHUYEN;
        }
    }
}
