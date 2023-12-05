using api_app_dien.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GiaDienTuController : Controller
    {
        DB db;
        public GiaDienTuController() 
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(string MaGiaDT)
        {
            DataTable giadientu = db.GetGiaDienTu(MaGiaDT);
            string json = db.DataTableToJSONWithJSONNet(giadientu);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
