using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace api_app_dien.Model
{
    public class DB
    {
        public string ConnectionString;
        public DB()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", false)
            .Build();
            ConnectionString = configuration.GetSection("connectionString").Value;
        }

        public DataTable GetTinhTPs()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM TinhTP";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }




        public DataTable GetQuanHuyens(int MaTinhTP)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM QuanHuyen WHERE MaTinhTP = " + MaTinhTP + "";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }
        public DataTable GetPhuongXas(int MaQuan)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM PhuongXa WHERE MaQuanHuyen = " + MaQuan + "";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetHinhThucSD()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM HinhThucSD";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetCapDienAp()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM CapDienAp";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetGiaDienTu(string MaGiaDT)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM GiaDienTu dt WHERE dt.MaGiaDT = N'"+MaGiaDT+"'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetGiaCo(string MaGiaCo)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM GiaCo gc WHERE gc.MaGiaCo = N'"+MaGiaCo+"'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        
        public List<Nha> ConvertDataTableToList(DataTable dt)
        {
            List<Nha> data= new List<Nha>();
            foreach (DataRow row in dt.Rows)
            {
                Nha item = new Nha();
                item.MANHA = row["MANHA"].ToString();
                item.SONHA = row["SONHA"].ToString();
                item.TENDUONG = row["TENDUONG"].ToString();
                item.TENCHUHO = row["TENCHUHO"].ToString();
                item.MAPHUONGXA = int.Parse(row["MAPHUONGXA"].ToString());
                data.Add(item);

            }
            return data;
        }
        



        public DataTable GetNha(int MaPhuongXa)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Nha WHERE MaPhuongXa = "+MaPhuongXa;
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }


        public DataTable GetKhachHang()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM KhachHang";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetNhaadd()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Nha";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetNhanVien()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM NhanVien";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetLoaiDHDienTu()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM LoaiDHDienTu";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetLoaiDHCo()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM LoaiDHCo";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetLoaiDH()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM LoaiDongHo";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetDongHoDien(int MaPhuongXa)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT dh.MaDongHoDien,dh.MaHinhThuc,dh.MaCapDienAp,dh.MaNha,dh.MaLoaiDH,dh.DiaChi FROM DongHoDien dh, Nha n WHERE dh.MaNha=n.MaNha and n.MaPhuongXa ="+MaPhuongXa;
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }
        public DataTable GetDongHoDiens()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM DongHoDien dh";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetDongHoDienMA(string MaDH)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT dh.MaDongHoDien, dh.MaHinhThuc, dh.MaCapDienAp, dh.MaLoaiDH FROM DongHoDien dh WHERE dh.MaDongHoDien = N'" + MaDH+"'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public List<DongHoDien> ConvertDataTableToListt(DataTable dt)
        {
            List<DongHoDien> data = new List<DongHoDien>();
            foreach (DataRow row in dt.Rows)
            {
                DongHoDien item = new DongHoDien();
                item.MADONGHODIEN = row["MADONGHODIEN"].ToString();
                item.MAHINHTHUC = row["MAHINHTHUC"].ToString();
                item.MACAPDIENAP = row["MACAPDIENAP"].ToString();
                item.MANHA = row["MANHA"].ToString();
                item.MALOAIDH = row["MALOAIDH"].ToString();
                item.DIACHI = row["DIACHI"].ToString();
                data.Add(item);

            }
            return data;
        }
        /*
        public List<KhachHang> ConvertDataTableToListsKH(DataTable dt)
        {
            List<KhachHang> data = new List<KhachHang>();
            foreach (DataRow row in dt.Rows)
            {
                KhachHang item = new KhachHang();
                item.MAKH = row["MAKH"].ToString();
                item.TenKH = row["TENKH"].ToString();
                item.SDT = row["SDT"].ToString();
                item.MATKHAU = row["MATKHAU"].ToString();
                item.MANHA = row["MANHA"].ToString();
                data.Add(item);

            }
            return data;
        }*/
        public List<HoaDonBangGhiDien> ConvertDataTableToLists(DataTable dt)
        {
            List<HoaDonBangGhiDien> data = new List<HoaDonBangGhiDien>();
            foreach (DataRow row in dt.Rows)
            {
                HoaDonBangGhiDien item = new HoaDonBangGhiDien();
                item.MABANGGHIDIEN = row["MABANGGHIDIEN"].ToString();
                item.MAHOADON = row["MAHOADON"].ToString();
                item.THANGGHI = Convert.ToDateTime(row["THANGGHI"]);
                item.CHISOCU = Convert.ToInt32(row["CHISOCU"]);
                item.CHISOMOI = Convert.ToInt32(row["CHISOMOI"]);
                item.CHISOTIEUTHU = Convert.ToInt32(row["CHISOTIEUTHU"]);
                item.TIENDIEN = Convert.ToSingle(row["TIENDIEN"]);
                item.TIENTHUE = Convert.ToSingle(row["TIENTHUE"]);
                item.THANHTIEN = Convert.ToSingle(row["THANHTIEN"]);
                item.TRANGTHAITHANHTOAN = row["TRANGTHAITHANHTOAN"].ToString();
                data.Add(item);

            }
            return data;
        }
        
        public DataTable GetHoaDonBangGhiDiens()
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT hd.MaBangGhiDien, hd.MaHoaDon,hd.ThangGhi,hd.ChiSoCu,hd.ChiSoMoi,hd.ChiSoTieuThu,hd.TienDien,hd.TienThue,hd.ThanhTien,hd.TrangThaiThanhToan,hd.MaDongHoDien \r\nFROM HoaDonBangGhiDien hd";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }
        public DataTable GetHoaDonBangGhiDien(int MaPhuongXa)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT hd.MaBangGhiDien, hd.MaHoaDon,hd.ThangGhi,hd.ChiSoCu,hd.ChiSoMoi,hd.ChiSoTieuThu,hd.TienDien,hd.TienThue,hd.ThanhTien,hd.TrangThaiThanhToan,hd.MaDongHoDien,n.SoNha,n.TenDuong,n.TenChuHo \r\nFROM HoaDonBangGhiDien hd, DongHoDien dh, Nha n\r\nWHERE  DH.MaDongHoDien = HD.MaDongHoDien AND hd.TrangThaiThanhToan = N'Chưa Thanh Toán' AND N.MaNha=DH.MaNha AND N.MaPhuongXa =" + MaPhuongXa;
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetHDKhachHang(String MaNha)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT hd.MaBangGhiDien, hd.MaHoaDon,hd.ThangGhi,hd.ChiSoCu,hd.ChiSoMoi,hd.ChiSoTieuThu,hd.TienDien,hd.TienThue,hd.ThanhTien,hd.TrangThaiThanhToan,hd.MaDongHoDien,n.SoNha,n.TenDuong,n.TenChuHo \r\nFROM HoaDonBangGhiDien hd, DongHoDien dh, Nha n\r\nWHERE  DH.MaDongHoDien = HD.MaDongHoDien AND hd.TrangThaiThanhToan = N'Chưa Thanh Toán' AND N.MaNha=DH.MaNha AND N.MaNha ='" + MaNha+"'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public DataTable GetMaxHD(string MaDH)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT COALESCE(MAX(hd.ChiSoMoi), 0) as ChiSoMoi FROM HoaDonBangGhiDien hd, DongHoDien dh\r\nWHERE hd.MaDongHoDien = dh.MaDongHoDien and hd.MaDongHoDien = N'" + MaDH+"'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public string DataTableToJSONWithJSONNet(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }


        public void AddHoaDon(HoaDonBangGhiDien hd)
        {
            string query = "INSERT INTO HoaDonBangGhiDien (MaBangGhiDien,MaHoaDon,ThangGhi,ChiSoCu,ChiSoMoi,ChiSoTieuThu,TienDien,TienThue,ThanhTien,TrangThaiThanhToan,MaDongHoDien)"+
                "VALUES(@MaBangGhiDien,@MaHoaDon,@ThangGhi,@ChiSoCu,@ChiSoMoi,@ChiSoTieuThu,@TienDien,@TienThue,@ThanhTien,@TrangThaiThanhToan,@MaDongHoDien)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@MaBangGhiDien", SqlDbType.NVarChar, 10).Value = hd.MABANGGHIDIEN;
                cmd.Parameters.Add("@MaHoaDon", SqlDbType.NVarChar, 10).Value = hd.MAHOADON;
                cmd.Parameters.Add("@ThangGhi", SqlDbType.DateTime).Value = hd.THANGGHI;
                cmd.Parameters.Add("@ChiSoCu", SqlDbType.Int).Value = hd.CHISOCU;
                cmd.Parameters.Add("@ChiSoMoi", SqlDbType.Int).Value = hd.CHISOMOI;
                cmd.Parameters.Add("@ChiSoTieuThu", SqlDbType.Int).Value = hd.CHISOTIEUTHU;
                cmd.Parameters.Add("@TienDien", SqlDbType.Money).Value = hd.TIENDIEN;
                cmd.Parameters.Add("@TienThue", SqlDbType.Money).Value = hd.TIENTHUE;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Money).Value = hd.THANHTIEN;
                cmd.Parameters.Add("@TrangThaiThanhToan", SqlDbType.NVarChar,20).Value = hd.TRANGTHAITHANHTOAN;
                cmd.Parameters.Add("@MaDongHoDien", SqlDbType.NVarChar,10).Value = hd.MADONGHODIEN;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }    
        }
        /*
        public void UpdateHoaDon(string MaBG)
        {
            string query = "UPDATE HoaDonBangGhiDien SET TrangThaiThanhToan = N'Đã thanh toán'  WHERE MaBangGhiDien =N'"+MaBG+"'";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                //cmd.Parameters.Add("@MaBangGhiDien", SqlDbType.NVarChar, 10).Value = hd.MABANGGHIDIEN;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        */
        //update hóa đơn
        public DataTable UpdateHoaDon(string MaBG)
        {
            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentException("No connection string in config.json");
            DataTable resultTable = new DataTable();
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = "UPDATE HoaDonBangGhiDien SET TrangThaiThanhToan = N'Đã thanh toán'  WHERE MaBangGhiDien =N'" + MaBG + "'";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(resultTable);
                    }
                }
            }
            return resultTable;
        }

        public void AddNha(Nha n)
        {
            string query = "INSERT INTO NHA (MaNha, SoNha, TenDuong, TenChuHo,MaPhuongXa)" +
                "VALUES (@MaNha,@SoNha,@TenDuong,@TenChuHo,@MaPHuongXa)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@MaNha", SqlDbType.NVarChar, 10).Value = n.MANHA;
                cmd.Parameters.Add("@SoNha", SqlDbType.NVarChar, 10).Value = n.SONHA;
                cmd.Parameters.Add("@TenDuong", SqlDbType.NVarChar, 30).Value = n.TENDUONG;
                cmd.Parameters.Add("@TenChuHo", SqlDbType.NVarChar, 50).Value = n.TENCHUHO;
                cmd.Parameters.Add("@MaPHuongXa", SqlDbType.Int).Value = n.MAPHUONGXA;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }    
        }

        public void AddNhanVien(NhanVien nv)
        {
            string query = "INSERT INTO NHANVIEN (MaNV, TenNV, NgaySinh, MatKhau, ChucVu)" +
                "VALUES (@MaNV,@TenNV,@NgaySinh,@MatKhau,@ChucVu)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar, 10).Value = nv.MANV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 30).Value = nv.TENNV;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.NVarChar, 30).Value = nv.NGAYSINH;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 30).Value = nv.MATKHAU;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 20).Value = nv.CHUCVU;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void AddKhachHang(KhachHang kh)
        {
            string query = "INSERT INTO KhachHang (MaKH, TenKH, Sdt, MatKhau, MaNha)" +
                "VALUES (@MaKH,@TenKH,@Sdt,@MatKhau,@MaNha)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@MaKH", SqlDbType.NVarChar, 10).Value = kh.MAKH;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 30).Value = kh.TenKH;
                cmd.Parameters.Add("@Sdt", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar, 30).Value = kh.MATKHAU;
                cmd.Parameters.Add("@MaNha", SqlDbType.NVarChar, 20).Value = kh.MANHA;
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void AddDH(DongHoDien dh)
        {
            string query = "INSERT INTO DongHoDien(MaDongHoDien,MaHinhThuc,MaCapDienAp,MaNha,MaLoaiDH,DiaChi)" +
                "VALUES (@MaDongHoDien,@MaHinhThuc,@MaCapDienAp,@MaNha,@MaLoaiDH,@DiaChi)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@MaDongHoDien", SqlDbType.NVarChar, 10).Value = dh.MADONGHODIEN;
                cmd.Parameters.Add("@MaHinhThuc", SqlDbType.NVarChar, 10).Value = dh.MAHINHTHUC;
                cmd.Parameters.Add("@MaCapDienAp", SqlDbType.NVarChar, 10).Value = dh.MACAPDIENAP;
                cmd.Parameters.Add("@MaNha", SqlDbType.NVarChar,10).Value = dh.MANHA;
                cmd.Parameters.Add("@MaLoaiDH", SqlDbType.NVarChar,10).Value = dh.MALOAIDH;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar,30).Value = dh.DIACHI;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
        /*
        public void AddKhachHang(KhachHang kh)
        {
            string query = "INSERT INTO KHACHHANG (TENKH,NGAYSINH,DIACHI,SDT,MATKHAU,MAPHUONGXA)" +
                            "VALUES (@TENKH,@NGAYSINH,@DIACHI,@SDT,@MATKHAU,@MAPHUONGXA)";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.Add("@TENKH", SqlDbType.NVarChar, 50).Value = kh.TENKH;
                cmd.Parameters.Add("@NGAYSINH", SqlDbType.DateTime, 50).Value = kh.NGAYSINH;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar, 100).Value = kh.DIACHI;
                cmd.Parameters.Add("@SDT", SqlDbType.Int).Value = kh.SDT;
                cmd.Parameters.Add("@MATKHAU", SqlDbType.NVarChar, 30).Value = kh.MATKHAU;
                cmd.Parameters.Add("@MAPHUONGXA", SqlDbType.Int).Value = kh.MAPHUONGXA;

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }
        */



    }
}
