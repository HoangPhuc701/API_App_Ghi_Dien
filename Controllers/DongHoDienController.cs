using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DongHoDienController:Controller
    {
        DB db;
        public DongHoDienController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(int MaPX)
        {
            DataTable DongHoDien = db.GetDongHoDien(MaPX);
            string json = db.DataTableToJSONWithJSONNet(DongHoDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpGet("GetAllDH")]
        public void GetAllDH(string MaDH)
        {
            DataTable DongHoDien = db.GetDongHoDienMA(MaDH);
            string json = db.DataTableToJSONWithJSONNet(DongHoDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpPost]
        public string Create(String MADONGHODIEN, String MAHINHTHUC, String MACAPDIENAP, String MANHA,String MALOAIDH,String DIACHI)
        {
            DongHoDien dh = new DongHoDien(MADONGHODIEN, MAHINHTHUC, MACAPDIENAP, MANHA, MALOAIDH, DIACHI);
            db.AddDH(dh);
            DataTable dhs = db.GetDongHoDiens();
            return db.DataTableToJSONWithJSONNet(dhs);
        }
    }
}
