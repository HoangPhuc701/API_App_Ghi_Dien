using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController:Controller
    {
        DB db;
        public NhanVienController()
        {
                db = new DB();
        }
        [HttpGet]
        public void GetAll()
        {
            DataTable nhanvien = db.GetNhanVien();
            string json = db.DataTableToJSONWithJSONNet(nhanvien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpPost]
        public string Create(String MANV, String TENNHANVIEN, string NGAYSINH, String MATKHAU, String CHUCVU,int MAPHUONGXA)
        {
            NhanVien nv = new NhanVien(MANV, TENNHANVIEN, NGAYSINH, MATKHAU, CHUCVU, MAPHUONGXA);
            db.AddNhanVien(nv);
            DataTable dhs = db.GetNhanVien();
            return db.DataTableToJSONWithJSONNet(dhs);
        }
    }
}
