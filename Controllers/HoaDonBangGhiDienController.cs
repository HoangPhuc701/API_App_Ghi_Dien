using api_app_dien.Model;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace api_app_dien.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonBangGhiDienController : Controller
    {
        DB db;
        public HoaDonBangGhiDienController()
        {
            db = new DB();
        }
        [HttpGet]
        public void GetAll(int MaPhuongXa)
        {
            DataTable HoaDonBangGhiDien = db.GetHoaDonBangGhiDien(MaPhuongXa);
            string json = db.DataTableToJSONWithJSONNet(HoaDonBangGhiDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpGet("GetMaxMaDH")]
        public void GetMaxHDl(string MaDH)
        {
            DataTable HoaDonBangGhiDien = db.GetMaxHD(MaDH);
            string json = db.DataTableToJSONWithJSONNet(HoaDonBangGhiDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpGet("HoaDonKH")]
        public void GetHDKH(string MaNha)
        {
            DataTable HoaDonBangGhiDien = db.GetHDKhachHang(MaNha);
            string json = db.DataTableToJSONWithJSONNet(HoaDonBangGhiDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
        }
        [HttpPost]
        public string CreateHoaDon(String MaBangGhi, String MaHD,DateTime ThangGhi,int ChiSoCu,int ChiSoMoi,int ChiSoTieuThu,double TienDien,double TienThue, double ThanhTien, String TrangThai, String MaDH)
        {
            HoaDonBangGhiDien hd = new HoaDonBangGhiDien( MaBangGhi,MaHD,ThangGhi,ChiSoCu,ChiSoMoi,ChiSoTieuThu, TienDien, TienThue,ThanhTien, TrangThai, MaDH);
            db.AddHoaDon(hd);
            DataTable nhas = db.GetHoaDonBangGhiDiens();
            return db.DataTableToJSONWithJSONNet(nhas);
        }
        [HttpPost("UpdateHD")]
        public void UpdateHD(string MaBG)
        {
            DataTable HoaDonBangGhiDien = db.UpdateHoaDon(MaBG);
            string json = db.DataTableToJSONWithJSONNet(HoaDonBangGhiDien);
            Response.Clear();
            Response.ContentType = "application.json; charset=uft-8";
            Response.WriteAsync(json);
            //Response.WriteAsync("{'message': 'Hóa đơn đã được cập nhật trạng thái thành công'}");
        }

    }
}
