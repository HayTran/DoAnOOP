using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    class KhachHang:ConNguoi
    {
        // khởi tạo một đối tượng thuộc lớp NhanVien chưa có trong CSDL
        public KhachHang (string maSo, string hoTen, bool gioiTinh, string soDienThoai, string diaChi)
        {
                this.maSo = maSo;
                this.hoTen = hoTen;
                this.gioiTinh = gioiTinh;
                this.soDienThoai = soDienThoai;
                this.diaChi = diaChi;
        }
        public string toString()
        {
            if (gioiTinh == true)
                return "Mã số khách hàng: " + maSo + "\t\tTên khách hàng: " + hoTen + "\nGiới tính: Nam " + "\tSố điện thoại: " + soDienThoai + "\nĐịa chỉ: " + diaChi;
            else
                return "Mã số khách hàng: " + maSo + "\t\tTên khách hàng: " + hoTen + "\nGiới tính: Nữ " + "\tSố điện thoại: " + soDienThoai + "\nĐịa chỉ: " + diaChi;
        }
        // lấy dữ liệu từ CSDL lên, cung cấp tất cả các thuộc tính cho đối tượng thuộc class KhachHang
        public void layDuLieu(string maSo)
        {
            this.maSo = maSo;
            KetNoiDuLieu.openConnect();
            SqlCommand cmd2 = new SqlCommand("select TenKH from KhachHang where MaKH = '"+maSo+"'",KetNoiDuLieu.conn);
            this.hoTen = Convert.ToString(cmd2.ExecuteScalar());
            SqlCommand cmd3 = new SqlCommand("select Nam from KhachHang where MaKH = '" + maSo + "'", KetNoiDuLieu.conn);
            this.gioiTinh = Convert.ToBoolean(cmd3.ExecuteScalar());
            SqlCommand cmd6 = new SqlCommand("select SoDienThoai from KhachHang where MaKH = '" + maSo + "'", KetNoiDuLieu.conn);
            this.soDienThoai = Convert.ToString(cmd6.ExecuteScalar());
            SqlCommand cmd7 = new SqlCommand("select DiaChi from KhachHang where MaKH = '" + maSo + "'", KetNoiDuLieu.conn);
            this.diaChi = Convert.ToString(cmd7.ExecuteScalar());
            KetNoiDuLieu.closeConnect();
        }
        // thêm thông tin của một đối tượng thuộc class KhachHang chưa có trong CSDL
        public override void themThongTin()
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("insert into KhachHang values ('"+maSo+"','"+hoTen+"','"+gioiTinh+"','"+soDienThoai+"','"+diaChi+"')");
            KetNoiDuLieu.closeConnect();
        }
        // sửa một đối tượng thuộc class KhachHang đã có trong CSDL. 
        public override void suaThongTin(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("update KhachHang set MaKH = '" + maSo + "',TenKH = '" + hoTen + "',Nam = '" + gioiTinh + "',SoDienThoai='" + soDienThoai + "',DiaChi='" + diaChi + "' where MaKH = '"+currentCell+"' ");
            KetNoiDuLieu.closeConnect();
        }
        // xóa một đối tượng thuộc class KhachHang đã có trong CSDL
        public override void xoaThongTin(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            DialogResult dR = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dR == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from KhachHang where MaKH = '" + currentCell + "' ");
            }
            KetNoiDuLieu.closeConnect();
        }
    }
}
