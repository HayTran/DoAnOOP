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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

 // Kiểm tra xem tài khoản này Admin hay Nhân viên bình thường hay không?
        private int kiemTraTaiKhoan() 
        {
            DataTable dt1,dt2 = new DataTable();

            dt1 = KetNoiDuLieu.executeLoadData("select * from TaiKhoan where MaNhanVien ='" + txtMaNhanVien.Text + "'and MatKhau = '" + txtMatKhau.Text + "' ");
            if (dt1.Rows.Count > 0)
            {
                 dt2 = KetNoiDuLieu.executeLoadData("select  * from TaiKhoan where MaNhanVien ='" + txtMaNhanVien.Text + "' and Admin = 'True' ");
                 if (dt2.Rows.Count > 0)
                 {
                     return 1;
                 }
                 else return 0;
               // return 5;
            }
            else return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (kiemTraTaiKhoan() == 1)
                {
                    FrmQLTaiKhoan frm1 = new FrmQLTaiKhoan();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    if (kiemTraTaiKhoan() == 0)
                    {
                        FrmBanHang frm2 = new FrmBanHang();
                        frm2.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Sai ten tai khoan hoac mat khau");
                }
                
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Co loi xay ra", ex.ToString());
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
        
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            KetNoiDuLieu.kiemTra();
        }

       

        
    }
}
