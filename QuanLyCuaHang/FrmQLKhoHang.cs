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
    public partial class FrmQLKhoHang : Form
    {
        int function = 0;
        public FrmQLKhoHang()
        {
            InitializeComponent();
        }
        #region
        private void dgvKhoHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvKhoHang.CurrentCell.RowIndex;
            txtMaMH.Text = dgvKhoHang.Rows[t].Cells[0].Value.ToString();
            txtTenMH.Text = dgvKhoHang.Rows[t].Cells[1].Value.ToString();
            txtSoLuong.Text = dgvKhoHang.Rows[t].Cells[2].Value.ToString();
            txtGiaTien.Text = dgvKhoHang.Rows[t].Cells[3].Value.ToString();
            dateNgayNhap.Text = dgvKhoHang.Rows[t].Cells[4].Value.ToString();
            dateNgaySX.Text = dgvKhoHang.Rows[t].Cells[5].Value.ToString();
            dateHSD.Text = dgvKhoHang.Rows[t].Cells[6].Value.ToString();
            txtNguoiNhap.Text = dgvKhoHang.Rows[t].Cells[7].Value.ToString();
        }
       private void khoaEdit()
       {
           btnChapNhan.Enabled = false;
           btnHuy.Enabled = false;
           btnThem.Enabled = true;
           btnSua.Enabled = true;
       }
         private void moEdit()
       {
           btnChapNhan.Enabled = true;
           btnHuy.Enabled = true;
           btnThem.Enabled = false;
           btnSua.Enabled = false;
       }
         private void btnThem_Click(object sender, EventArgs e)
         {
             function = 1;
             moEdit();
         }

       
         private void btnHuy_Click(object sender, EventArgs e)
         {
             function = 0;
             khoaEdit();
         }

        private void loadBang()
        {
            dgvKhoHang.DataSource = KetNoiDuLieu.executeLoadData("select * from KhoHang");
            khoaEdit();
        }
        private void NhapKho_Load(object sender, EventArgs e)
        {
            loadBang();
            
        }
        #endregion



        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            KhoHang a = new KhoHang(txtMaMH.Text, txtTenMH.Text, txtSoLuong.Text, txtGiaTien.Text, dateNgayNhap.Text, dateNgaySX.Text, dateHSD.Text, txtNguoiNhap.Text);
            if (function == 1)
            {
                a.themSanPham();
            }
            else
                if (function == 2)
                {
                    a.suaSanPham(dgvKhoHang.Rows[dgvKhoHang.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
            loadBang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
    
            function = 2;
            moEdit();
        }
       
        private void btnXoa_Click(object sender, EventArgs e)
        {
          
            loadBang();
        }

        private void dateNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

 


      

       


        
    }
}
