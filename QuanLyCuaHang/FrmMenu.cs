using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyCuaHang
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnQLTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQLKhachHang frm = new FrmQLKhachHang();
            frm.Show();
            this.Hide();
        }

        private void btnQLKhoHang_Click(object sender, EventArgs e)
        {
            FrmQLKhoHang frm = new FrmQLKhoHang();
            frm.Show();
            this.Hide();
        }

        private void btnQLNhanVien_Click(object sender, EventArgs e)
        {
            FrmQLNhanVien frm =new  FrmQLNhanVien();
            frm.Show();
            this.Hide();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            FrmQLKhachHang frm = new FrmQLKhachHang();
            frm.Show();
            this.Hide();
        }

        private void btnTinhLuongNV_Click(object sender, EventArgs e)
        {
            FrmQLLuongNV frm = new FrmQLLuongNV();
            frm.Show();
            this.Hide();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnQLKhoHang_Click_1(object sender, EventArgs e)
        {
            FrmQLKhoHang frm = new FrmQLKhoHang();
            frm.Show();
            this.Hide();
        }

        private void btnQLNhanVien_Click_1(object sender, EventArgs e)
        {
            FrmQLNhanVien frm = new FrmQLNhanVien();
            frm.Show();
            this.Hide();
        }

        private void btnQLTaiKhoan_Click_1(object sender, EventArgs e)
        {
            FrmQLTaiKhoan frm = new FrmQLTaiKhoan();
            frm.Show();
            this.Hide();
        }

        private void btnXemThongKe_Click_1(object sender, EventArgs e)
        {
          
        }

        private void btnQLLuongNV_Click(object sender, EventArgs e)
        {
            FrmQLLuongNV frm = new FrmQLLuongNV();
            frm.Show();
            this.Hide();
        }





    }
}
