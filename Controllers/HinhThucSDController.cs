using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HinhThucSDController : Controller
    {
        DB db;
        public HinhThucSDController()
        {
            db= new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable hinhthucsd = db.GetHinhThucSD();
            string json = db.DataTableToJSONWithJSONNet(hinhthucsd);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
