using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuanHuyenController : Controller
    {
        DB db;
        public QuanHuyenController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(int MaTinhTP)
        {
            DataTable quanhuyens = db.GetQuanHuyens(MaTinhTP);
            string json = db.DataTableToJSONWithJSONNet(quanhuyens);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
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
