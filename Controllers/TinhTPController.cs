using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TinhTPController : Controller
    {
        DB db;
        public TinhTPController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable tinhtps = db.GetTinhTPs();
            string json = db.DataTableToJSONWithJSONNet(tinhtps);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }

    }
}
