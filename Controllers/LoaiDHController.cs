using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDHController:Controller
    {
        DB db;
        public LoaiDHController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable LoaiDH = db.GetLoaiDH();
            string json = db.DataTableToJSONWithJSONNet(LoaiDH);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
