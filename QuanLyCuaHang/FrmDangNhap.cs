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
        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien a = new NhanVien(txtMaNhanVien.Text,txtMatKhau.Text);
            try
            {
                if (a.kiemTraDangNhap() == 1)
                {
                    FrmQLTaiKhoan frm1 = new FrmQLTaiKhoan();
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    if (a.kiemTraDangNhap() == 0)
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
