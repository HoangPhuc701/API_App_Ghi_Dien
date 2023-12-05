using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDHCoController:Controller
    {
        DB db;
        public LoaiDHCoController()
        {
            db = new DB();
        }

        [HttpGet]
        public void GetAll()
        {
            DataTable LoaiDHCo = db.GetLoaiDHCo();
            string json = db.DataTableToJSONWithJSONNet(LoaiDHCo);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
