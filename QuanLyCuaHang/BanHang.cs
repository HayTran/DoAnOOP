using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace QuanLyCuaHang
{
    class BanHang
    {
       // tạo danh sách cách mặt hàng được mua cũng như số lượng mua, chưa được lưu xuống CSDL
        public static string[] arrayMaMH = new string[100];
        public static string[] arrayTenMH = new string[100];
        public static string[] arrayGiaTien = new string[100];
        public static string[] arraySLMua = new string[100];
        private static int chiSoMang;
        public static int maDH;
        public static int maKH;
        // lấy mã khách hàng hiện tại ở dưới CSDL lên
        public static int layMaKhachHang()
        {
            KetNoiDuLieu.openConnect();
            SqlCommand cmd = new SqlCommand("select MAX(MaKH) from KhachHang", KetNoiDuLieu.conn);
            int retMaKH = Convert.ToInt32(cmd.ExecuteScalar());
            KetNoiDuLieu.closeConnect();
            maKH = retMaKH + 1 ; // tăng mã khách hàng mới nhất lên 1 đơn vị để cung cấp MaKH cho khách hàng tiếp theo
             return retMaKH;
        }
        // lấy giá trị đơn hàng hiện tại ở dưới CSDL lên
        public static int layMaDonHang()
        {
            KetNoiDuLieu.openConnect();
            SqlCommand cmd = new SqlCommand("select MAX(MaDH) from DonHang", KetNoiDuLieu.conn);
            int retMaDH = Convert.ToInt32(cmd.ExecuteScalar());
            KetNoiDuLieu.closeConnect();
            maDH = retMaDH + 1; // tăng mã đơn hàng mới nhất lên 1 đơn vị để cung cấp MaDH cho khách hàng tiếp theo
            return retMaDH;
        }
       
        //  khởi tạo một hóa đơn mới
        public static void khoiTaoHoaDon()
        {
            chiSoMang = 0;
        }
        // tạo các hóa đơn bằng cách thêm lần lượt các mặt hàng được chọn lưu vào mảng ở bộ nhớ máy tính. Input: Mã MH, số lượng mua
        public static void taoHoaDon(string maMH, string soLuongMua)
        {
            MatHang mH = new MatHang(maMH);
            arrayMaMH[chiSoMang] = mH.maMH;
            arrayTenMH[chiSoMang] = mH.tenMH;
            arrayGiaTien[chiSoMang] = Convert.ToString(mH.giaTien);
            arraySLMua[chiSoMang] = soLuongMua;
            chiSoMang++;
        }
        // xuất thông tin khách hàng, thông tin về các mặt hàng được mua trong đơn hàng, thông tin mã nhân viên bán hàng
        public static string xuatHoaDon(KhachHang kH)
        {
            string a = "Mã hóa đơn: " + maDH;
            a += "\nTên mặt hàng                    Giá tiền                    Số lượng";
            for (int i = 0; i < chiSoMang ; i++)
            {
                a = a + "\n" + arrayTenMH[i] + "                    " + arrayGiaTien[i] + "                    " + arraySLMua[i];
            }
            return "THÔNG TIN KHÁCH HÀNG:\n\n"+kH.toString() + "\n\n\nTHÔNG TIN ĐƠN HÀNG:\n\n" + a;
        }

       // thực hiện tính tổng tiền chưa tính phần giảm giá
        public static double tinhTongTien()
        {
            double tongTien = 0;
            for (int i = 0; i < chiSoMang; ++i)
            {
                tongTien += Convert.ToInt64(arrayGiaTien[i]) * Convert.ToInt64(arraySLMua[i]);
            }

            return tongTien;
        }
        // thực hiện việc tính tính thực phải trả(đã trừ giảm giá)
        public static double tinhTongTienThucTe(string tongTien, string phanTramGiamGia)
        {
            return Convert.ToDouble(tongTien) - (Convert.ToDouble(tongTien) * Convert.ToDouble(phanTramGiamGia))/100;
        }
        //tính tiền thối lại cho khách
        public static double tinhTienTraLai(string tienKhachDua, string tienThucTe)
        {
            return Convert.ToDouble(tienKhachDua) - Convert.ToDouble(tienThucTe);
        }

        // thực hiện việc lưu thông tin đơn hàng vào bảng DonHa
        public static void luuDonHang(string tienGiamGia, string tienThucTe)
        {
            try
            {
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery(string.Format("insert into DonHang values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}','{6}')", 
                                                                    maDH, 
                                                                    maKH, 
                                                                    tinhTongTien(),
                                                                    Convert.ToString(tienGiamGia),
                                                                    Convert.ToString(tienThucTe),
                                                                    DateTime.Now, 
                                                                    NhanVien.maNVDangNhap));
                KetNoiDuLieu.closeConnect();
                luuChiTietDonHang();
                truSanPham();
                luuDonHangNV(tienThucTe);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR");
            }                   
        }
        // thực hiện việc lưu thông tin chi tiết đon hàng vào bảng ChiTietDonHang
        public static void luuChiTietDonHang()
        {
            for (int i = 0; i < chiSoMang; i++)
            {
               
                MatHang MH = new MatHang(arrayMaMH[i]);
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery(string.Format("insert into ChiTietDonHang values ('{0}', '{1}', '{2}', '{3}', '{4}')", 
                                                        maDH,
                                                        MH.maMH,
                                                        MH.tenMH,
                                                        MH.giaTien,
                                                        Convert.ToInt32(arraySLMua[i])
                                                        )
                                          );
                KetNoiDuLieu.closeConnect();
            }
        }
        // thực hiện lưu khách hàng vào bảng KhachHang
        public static void luuKhachHang(KhachHang kH)
        {
            kH.themThongTin();
        }
        // thực hiện việc trừ số lượng sản phẩm được mua
        public static void truSanPham()
        {
            for (int i = 0; i < chiSoMang; i++)
            {
                MatHang mH = new MatHang(arrayMaMH[i]);
                mH.soLuong -= Convert.ToInt32(arraySLMua[i]);
                KetNoiDuLieu.openConnect();        
                KetNoiDuLieu.executeQuery("update KhoHang set SoLuong = '" + mH.soLuong + "' where MaMH = '" + arrayMaMH[i] + "'");
                KetNoiDuLieu.closeConnect();
            }
        }
         //luư đơn hành xuống bảng Lương Nhân viên
        public static void luuDonHangNV(string tienThucTe)
        {
             try
            {
                KetNoiDuLieu.openConnect();
                SqlCommand cmdSelect_SoDonHang = new SqlCommand(string.Format("SELECT SoDonHang FROM LuongNV where MaNV = '"+NhanVien.maNVDangNhap+"'"), KetNoiDuLieu.conn);
                int soDonHangHienTai = Convert.ToInt32(cmdSelect_SoDonHang.ExecuteScalar()) +1;
          
                KetNoiDuLieu.closeConnect();

                KetNoiDuLieu.openConnect();
                SqlCommand cmdSelect_TienBanDuoc = new SqlCommand(string.Format("SELECT TienBanDuoc FROM LuongNV where MaNV = '" + NhanVien.maNVDangNhap + "'"), KetNoiDuLieu.conn);
                int soTienBanDuoc = Convert.ToInt32(cmdSelect_TienBanDuoc.ExecuteScalar()) + Convert.ToInt32(tienThucTe);
                KetNoiDuLieu.closeConnect();
                 KetNoiDuLieu.openConnect();
                 KetNoiDuLieu.executeQuery("update LuongNV set SoDonHang = '" +soDonHangHienTai + "', TienBanDuoc = '"+soTienBanDuoc+"' where MaNV = '" + NhanVien.maNVDangNhap + "'");
                 KetNoiDuLieu.closeConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
