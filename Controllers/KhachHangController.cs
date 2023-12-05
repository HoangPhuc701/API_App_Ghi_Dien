using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : Controller
    {
        DB db;
        public KhachHangController()
        {
            db = new DB();
        }
        
        [HttpGet]
        public void GetAll()
        {
            DataTable KhachHang = db.GetKhachHang();
            string json = db.DataTableToJSONWithJSONNet(KhachHang);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }

        [HttpPost]
        public string CreateKH(String MaKh, String TenKH, int Sdt, String MatKhau, String MaNha)
        {
            KhachHang kh = new KhachHang(MaKh, TenKH, Sdt, MatKhau, MaNha);
            db.AddKhachHang(kh);
            DataTable khs = db.GetKhachHang();
            return db.DataTableToJSONWithJSONNet(khs);
        }
    }
}
