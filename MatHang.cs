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
        private string tenMH;
        public int soLuong;
        public int giaTien;
        private DateTime ngayNhap;
        private DateTime ngaySanXuat;
        private DateTime hanSuDung;
        private string nguoiNhap;
        public MatHang()
        {
            this.maMH = null;
            this.tenMH = null;
            this.soLuong = 0;
            this.giaTien = 0;
            this.nguoiNhap = null;
            
        }
        // lấy tất cả các thuộc tính của một đối tượng thuộc lớp MatHang khi đã biết MaMH
        public void layDuLieu (string maMH)
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
                  this.ngaySanXuat = Convert.ToDateTime(cmd5.ExecuteScalar());
                  SqlCommand cmd6 = new SqlCommand("select NguoiNhap from KhoHang where MaMH = '" + maMH + "'", conn);
                  this.nguoiNhap = Convert.ToString(cmd6.ExecuteScalar());
                  KetNoiDuLieu.closeConnect();
              }
              catch
              {
                  MessageBox.Show("Có lỗi xảy ra!");
              }
              

        }
        // thực hiện việc kiểm tra xem số lượng nhập vào ô bán có phù hợp với số lượng ở trong kho hay không?
        public void kiemTraSanPham(int soLuongMua)
        {
            if (soLuongMua > soLuong)
            {
                MessageBox.Show("Không đủ sản phẩm để bán");
            }
        }
        // thực hiện việc trừ sản phẩm trong kho khi bán sản phẩm cho khách hàng
        public void truSanPham(int soLuongMua)
        {
               soLuong = soLuong - soLuongMua;
               KetNoiDuLieu.openConnect();
               KetNoiDuLieu.executeQuery("update KhoHang set SoLuong = '"+Convert.ToInt32(soLuong)+"' where MaMH = '"+maMH+"' ");
               //KetNoiDuLieu.closeConnect();
               kiemTraTrungDuLieu();
           
        }
        //Kiểm tra xem mã sản nhập vào có trùng với sản phẩm có trong kho hàng chưa? Sản phẩm bị trùng khi 2 khóa MaMH và NgaySX là giống nhau. Nếu có thì yêu cầu người dùng dùng chức năng(thao tác) chỉnh sửa, không được dùng chắc năng thêm
        public int kiemTraTrungDuLieu()
        {
            KetNoiDuLieu.openConnect(); //and NgaySX = '"+ngaySanXuat+"'
            DataTable dt = new DataTable();
            dt = KetNoiDuLieu.executeLoadData("select * from KhoHang where MaMH = '"+maMH+"' ");
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

    }
}
