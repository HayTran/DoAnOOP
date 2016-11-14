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
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent(); 

        }
        
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MatHang a = new MatHang();
            a.layDuLieu(txtMaMH.Text);
            a.truSanPham(int.Parse(txtSoLuongMua.Text));
            txtSoLuongCon.Text = a.soLuong.ToString();
        }

       
        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            MatHang a = new MatHang();
            a.layDuLieu(txtMaMH.Text);
            txtGiaTien.Text = a.giaTien.ToString();
            txtSoLuongCon.Text = a.soLuong.ToString();
          
        }

        private void txtSoLuongMua_TextChanged(object sender, EventArgs e)
        {
            /*MatHang a = new MatHang(txtMaMH.Text);
            if (txtSoLuongMua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào số lượng");
            }
            else
            {
                a.kiemTraSanPham(Convert.ToInt32(txtSoLuongMua.Text));
            }
          */
        }


        


        
    }
}
