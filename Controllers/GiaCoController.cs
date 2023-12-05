using api_app_dien.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaCoController : Controller
    {
        DB db;
        public GiaCoController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(string MaGiaCo)
        {
            DataTable giaco = db.GetGiaCo(MaGiaCo);
            string json = db.DataTableToJSONWithJSONNet(giaco);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
