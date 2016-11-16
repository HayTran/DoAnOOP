using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuanLyCuaHang
{
    class NhanVien:ConNguoi
    {
        public static string maNVDangNhap = "";
        // cung cấp thêm các thuộc tính riêng mà Nhân viên cần có
        public string soCMND;
        public DateTime ngaySinh;
        public string matKhau;
        public bool admin;

        // khởi tạo một đối tượng thuộc lớp NhanVien chưa có trong CSDL (phục vụ cho bảng TaiKhoan)
        public NhanVien(string maSo, string matKhau, bool admin)
        {
            this.maSo = maSo;
            this.matKhau = matKhau;
            this.admin = admin;
        }
        // khởi tạo một đối tượng nhằm đăng nhập vào hệ thống và lưu lại người nào đang đăng nhập nhằm lưu vào hóa đơn bán hàng
        public NhanVien(string maSo, string matKhau)
        {
            this.maSo = maSo;
            this.matKhau = matKhau;
        }
        // kiểm tra đăng nhập bằng cách dùng một đối tượng để truy cập
        public int kiemTraDangNhap()
        {
            DataTable dt1, dt2 = new DataTable();

            dt1 = KetNoiDuLieu.executeLoadData("select * from TaiKhoan where MaNV ='" +maSo+ "'and MatKhau = '" +matKhau+ "' ");
            if (dt1.Rows.Count > 0)
            {
                dt2 = KetNoiDuLieu.executeLoadData("select  * from TaiKhoan where MaNV ='" + maSo + "' and Admin = 'True' ");
                if (dt2.Rows.Count > 0)
                {
                    return 1;
                }
                else
                {
                    maNVDangNhap = maSo;
                    return 0;
                }
            }
            else return -1;
        }

        // lưu mã nhân viên người vừa đăng nhập xuống CSDL nhằm để lấy lên khi dùng trong trường hợp mở Form bán hàn
        // khởi tạo một đối tượng thuộc lớp NhanVien chưa có trong CSDL (phục vụ cho bảng NhanVien)
        public NhanVien (string maSo, string hoTen, bool gioiTinh, string ngaySinh, string soCMND, string soDienThoai, string diaChi)
        {
            this.maSo = maSo;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = Convert.ToDateTime(ngaySinh);
            this.soCMND = soCMND;
            this.soDienThoai = soDienThoai;
            this.diaChi  = diaChi;
        }
        // lấy dữ liệu từ CSDL lên, cung cấp tất cả các thuộc tính cho đối tượng thuộc class NhanVien, phục vụ bảng NhanVien
        public void layDuLieu(string maSo)
        {
            this.maSo = maSo;
            KetNoiDuLieu.openConnect();
            SqlCommand cmd2 = new SqlCommand("select TenNV from NhanVien where MaNV = '"+maSo+"'",KetNoiDuLieu.conn);
            this.hoTen = Convert.ToString(cmd2.ExecuteScalar());
            SqlCommand cmd3 = new SqlCommand("select Nam from NhanVien where MaNV = '" + maSo + "'", KetNoiDuLieu.conn);
            this.gioiTinh = Convert.ToBoolean(cmd3.ExecuteScalar());
            SqlCommand cmd4 = new SqlCommand("select NgaySinh from NhanVien where MaNV = '" + maSo + "'", KetNoiDuLieu.conn);
            this.ngaySinh = Convert.ToDateTime (cmd4.ExecuteScalar());
            SqlCommand cmd5 = new SqlCommand("select CMND from NhanVien where MaNV = '" + maSo + "'", KetNoiDuLieu.conn);
            this.soCMND = Convert.ToString(cmd5.ExecuteScalar());
            SqlCommand cmd6 = new SqlCommand("select SoDienThoai from NhanVien where MaNV = '" + maSo + "'", KetNoiDuLieu.conn);
            this.soDienThoai = Convert.ToString(cmd6.ExecuteScalar());
            SqlCommand cmd7 = new SqlCommand("select DiaChi from NhanVien where MaNV = '" + maSo + "'", KetNoiDuLieu.conn);
            this.diaChi = Convert.ToString(cmd7.ExecuteScalar());
            KetNoiDuLieu.closeConnect();
        }
        // thêm thông tin của một đối tượng nhân viên chưa có trong CSDL
        public override void themThongTin()
        {
            themTaiKhoan();
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("insert into NhanVien values ('"+maSo+"','"+hoTen+"','"+gioiTinh+"','"+ngaySinh+"','"+soCMND+"','"+soDienThoai+"','"+diaChi+"')");
            KetNoiDuLieu.closeConnect();

        }
        // sửa một đối tượng thuộc class NhanVien đã có trong CSDL. 
        public override void suaThongTin(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("update NhanVien set MaNV = '" + maSo + "',TenNV = '" + hoTen + "',Nam = '" + gioiTinh + "',NgaySinh = '" + ngaySinh + "',CMND ='" + soCMND + "',SoDienThoai='" + soDienThoai + "',DiaChi='" + diaChi + "' where MaNV = '"+currentCell+"' ");
            KetNoiDuLieu.closeConnect();
        }
        // xóa một đối tượng thuộc class NhanVien đã có trong CSDL
        public override void xoaThongTin(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            DialogResult dR = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dR == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from NhanVien where MaNV = '" + currentCell + "' ");
                xoaTaiKhoan(currentCell);
            }
            KetNoiDuLieu.closeConnect();
        }
        // thêm tài khoản vào trong bảng Tài khoản
        public void themTaiKhoan()
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("insert into TaiKhoan values ('"+maSo+"','')");
            KetNoiDuLieu.closeConnect();
        }
        // xóa tài khoản trong bảng Tài khoản
        public void xoaTaiKhoan(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("delete from TaiKhoan where MaNV = '" +currentCell+ "' ");
            KetNoiDuLieu.closeConnect();
        }
    }
}
