using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDHDienTuController : Controller
    {
        DB db;
        public LoaiDHDienTuController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable LoaiDHDienTu = db.GetLoaiDHDienTu();
            string json = db.DataTableToJSONWithJSONNet(LoaiDHDienTu);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
