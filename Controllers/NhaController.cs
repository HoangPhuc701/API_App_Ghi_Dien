using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhaController : Controller
    {
        DB db;
        public NhaController() 
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(int MaPhuongXa)
        {
            DataTable nha = db.GetNha(MaPhuongXa);
            string json = db.DataTableToJSONWithJSONNet(nha);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpPost]
        public string Create(String MANHA, String SONHA, String TENDUONG,string TENCHUHO,int MaPhuongXa)
        {
            Nha nha = new Nha(MANHA, SONHA, TENDUONG,TENCHUHO, MaPhuongXa);
            db.AddNha(nha);
            DataTable nhas = db.GetNhaadd();
            return db.DataTableToJSONWithJSONNet(nhas);
        }

        /*
       [HttpPost]
       public string Create(string TENKH, DateTime NGAYSINH, String DIACHI, int SDT, string MATKHAU, int MAPHUONGXA)
       {
           KhachHang quanhuyens = new KhachHang(TENKH, NGAYSINH, DIACHI, SDT, MATKHAU, MAPHUONGXA);
           db.AddKhachHang(quanhuyens);
           DataTable quanhuyens = db.GetQuanHuyens();
           return db.DataTableToJSONWithJSONNet(quanhuyens);
       }
       */

    }
}
