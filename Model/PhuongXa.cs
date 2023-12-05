namespace api_app_dien.Model
{
    public class PhuongXa
    {
        public int MAPHUONGXA;
        public int MAQUANHUYEN;
        public string TENPHUONGXA;
        public PhuongXa() { }
        public PhuongXa(int mAPHUONGXA,int mQUANHUYEN,string tENPHUONGXA) 
        { 
            MAPHUONGXA= mAPHUONGXA;
            MAQUANHUYEN= mQUANHUYEN;
            TENPHUONGXA= tENPHUONGXA;
        }



    }
    
}
