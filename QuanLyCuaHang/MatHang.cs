using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCuaHang
{
    class MatHang: KetNoiDuLieu
    {
        public string maMH;
        public string tenMH;
        public int soLuong;
        public int giaTien;
        private DateTime ngayNhap;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private string nguoiNhap;

      
        //khu vực xử lý phần thêm sửa xóa mặt hàng
        #region 
        // khởi tạo một đối tượng chưa có trong CSDL thuộc class MatHang
        public MatHang (string maMH, string tenMH, string soLuong, string giaTien, string ngayNhap, string ngaySanXuat, string hanSuDung, string nguoiNhap)
        {
            this.maMH  = maMH;
            this.tenMH = tenMH;
            this.soLuong = int.Parse(soLuong);
            this.giaTien = int.Parse(giaTien);
            this.ngayNhap = Convert.ToDateTime(ngayNhap);
            this.ngaySanXuat = Convert.ToDateTime(ngaySanXuat);
            this.hanSuDung = Convert.ToDateTime(hanSuDung);
            this.nguoiNhap = nguoiNhap;
        }
       
        // lấy dữ liệu từ CSDL lên khi biết MaMH thuộc class MatHang
        public MatHang (string maMH)
        {
            try
              {
                  this.maMH = maMH;
                  KetNoiDuLieu.openConnect();
                  SqlCommand cmd = new SqlCommand("select TenMH from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.tenMH = Convert.ToString(cmd.ExecuteScalar());
                  SqlCommand cmd1 = new SqlCommand("select SoLuong from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.soLuong = Convert.ToInt32(cmd1.ExecuteScalar());
                  SqlCommand cmd2 = new SqlCommand("select GiaTien from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.giaTien = Convert.ToInt32(cmd2.ExecuteScalar());
                  SqlCommand cmd3 = new SqlCommand("select NgayNhap from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.ngayNhap = Convert.ToDateTime(cmd3.ExecuteScalar());
                  SqlCommand cmd4 = new SqlCommand("select NgaySX from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.ngaySanXuat = Convert.ToDateTime(cmd4.ExecuteScalar());
                  SqlCommand cmd5 = new SqlCommand("select HSD from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.hanSuDung = Convert.ToDateTime(cmd5.ExecuteScalar());
                  SqlCommand cmd6 = new SqlCommand("select NguoiNhap from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.nguoiNhap = Convert.ToString(cmd6.ExecuteScalar());
                  KetNoiDuLieu.closeConnect();
              }
              catch
              {
                  MessageBox.Show("Có lỗi xảy ra!");
              }
        }

        //thêm một đối tượng mới vào CSDL thuộc class KhoHang
        public void themSanPham()
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("insert into KhoHang values ('"+maMH+"','"+tenMH+"','"+soLuong+"','"+giaTien+"','"+ngayNhap+"','"+ngaySanXuat+"','"+hanSuDung+"','"+nguoiNhap+"')");
            KetNoiDuLieu.closeConnect();
        }
        //sửa một đối tượng thuộc class KhoHang đã có trong CSDL
        public void suaSanPham(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            KetNoiDuLieu.executeQuery("update KhoHang set MaMH = '" + maMH + "',TenMH ='" + tenMH + "',SoLuong = '" + soLuong + "',GiaTien='" + giaTien + "',NgayNhap='" + ngayNhap + "',NgaySX='" + ngaySanXuat + "',HSD = '" + hanSuDung + "',NguoiNhap='" + nguoiNhap + "' where MaMH = '"+currentCell+"'");
            KetNoiDuLieu.closeConnect();
        }
        //xóa một đối tượng thuộc class KhoHang đã có trong CSDL
        public void xoaSanPham(string currentCell)
        {
            KetNoiDuLieu.openConnect();
            DialogResult  dR = MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dR == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from KhoHang where MaMH = '" + currentCell + "' ");
            }
            KetNoiDuLieu.closeConnect();
        }
        // thực hiện việc trừ sản phẩm trong kho khi bán sản phẩm cho khách hàng.
        public void truSanPham(int soLuongMua)
        
        {
            //kiemTraSanPham(soLuongMua);
            if (soLuong >= soLuongMua)
            {
                soLuong = soLuong - soLuongMua;
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("update KhoHang set SoLuong = '" + Convert.ToInt32(soLuong) + "' where MaMH = '" + maMH + "' ");
                KetNoiDuLieu.closeConnect();
                kiemTraTrungDuLieu();
            }
        }
        //Kiểm tra xem mã sản nhập vào có trùng với sản phẩm có trong kho hàng chưa? Sản phẩm bị trùng khi 2 khóa MaMH và NgaySX là giống nhau. 
        //Nếu có thì yêu cầu người dùng dùng chức năng(thao tác) chỉnh sửa, không được dùng chắc năng thêm.
        public int kiemTraTrungDuLieu()
        {
            KetNoiDuLieu.openConnect(); 
            DataTable dt = new DataTable();
            dt = KetNoiDuLieu.executeLoadData("select * from KhoHang where MaMH = '"+maMH+"'");
            KetNoiDuLieu.closeConnect();
            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        #endregion
    }
}
