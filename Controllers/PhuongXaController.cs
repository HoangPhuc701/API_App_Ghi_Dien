using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PhuongXaController : Controller
    {
        DB db;
        public PhuongXaController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(int MaQuan)
        {
            DataTable phuongxas = db.GetPhuongXas(MaQuan);
            string json = db.DataTableToJSONWithJSONNet(phuongxas);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
    }
}
