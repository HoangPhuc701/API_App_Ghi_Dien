namespace api_app_dien.Model
{
    public class LoaiDHCo
    {
        public string MADONGHOCO;
        public string TENDHCO;
        public string MAGIACO;
        public string MALOAIDH;
        public LoaiDHCo() { }
        public LoaiDHCo(string mADONGHOCO, string tENDHCO, string mAGIACO, string mALOAIDH)
        {
            MADONGHOCO = mADONGHOCO;
            TENDHCO = tENDHCO;
            MAGIACO = mAGIACO;
            MALOAIDH = mALOAIDH;
        }
    }
}
