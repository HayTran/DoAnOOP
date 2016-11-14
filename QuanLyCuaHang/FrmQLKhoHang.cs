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
        int i = 0;
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
             i = 1;
             moEdit();
         }

       
         private void btnHuy_Click(object sender, EventArgs e)
         {
             i = 0;
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
            if (i == 1)
            {
                MatHang mH = new MatHang();
                mH.layDuLieu(txtMaMH.Text);
                if (mH.kiemTraTrungDuLieu() == 1)
                {
                    MessageBox.Show("Bị trùng hàng có trong kho! Bạn chỉ có thể sửa để thêm số lượng!","Cảnh báo!");
                    goto A;
                }
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("insert into KhoHang values ('" + txtMaMH.Text + "','" + txtTenMH.Text + "','" + int.Parse(txtSoLuong.Text)+ "','" + int.Parse(txtGiaTien.Text) + "','" + Convert.ToDateTime(dateNgayNhap.Text) + "','" + Convert.ToDateTime(dateNgaySX.Text) + "','" + Convert.ToDateTime(dateHSD.Text) + "','" + txtNguoiNhap.Text + "')");
                loadBang();
                KetNoiDuLieu.closeConnect();
            }
            else
                if (i == 2)
                {
                    KetNoiDuLieu.openConnect();
                    KetNoiDuLieu.executeQuery("update KhoHang set MaMH= '" + txtMaMH.Text + "',TenMH = '" + txtTenMH.Text + "',SoLuong = '" + int.Parse(txtSoLuong.Text) + "',GiaTien ='" + int.Parse(txtGiaTien.Text) + "',NgayNhap='" + Convert.ToDateTime(dateNgayNhap.Text) + "',NgaySX ='" + Convert.ToDateTime(dateNgaySX.Text) + "',HSD='" + Convert.ToDateTime(dateHSD.Text) + "',NguoiNhap ='" + txtNguoiNhap.Text + "' where MaMH = '" + dgvKhoHang.Rows[dgvKhoHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    loadBang();
                    KetNoiDuLieu.closeConnect();
                }
            A:
            loadBang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
    
            i = 2;
            moEdit();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoiDuLieu.openConnect();
            DialogResult = MessageBox.Show("Ban co muon xoa khong?", "Thong bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
               
                KetNoiDuLieu.executeQuery("delete from KhoHang where MaMH = '" + dgvKhoHang.Rows[dgvKhoHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                loadBang();
            }
            KetNoiDuLieu.closeConnect();
        }

        private void dateNgayNhap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

 


      

       


        
    }
}
