using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CapDienApController : Controller
    {
        DB db;
        public CapDienApController ()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable capdienap = db.GetCapDienAp();
            string json = db.DataTableToJSONWithJSONNet(capdienap);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
