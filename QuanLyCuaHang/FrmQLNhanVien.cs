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
    public partial class FrmQLNhanVien : Form
    {
        public FrmQLNhanVien()
        {
            InitializeComponent();
        }

        #region
        private void moEdit()
        {
            btnChapNhan.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void khoaEdit()
        {
            btnChapNhan.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void loadBang()
        {
            dgvNhanVien.DataSource = KetNoiDuLieu.executeLoadData("select * from NhanVien");
            khoaEdit();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvNhanVien.CurrentCell.RowIndex;
            txtMaNV.Text = dgvNhanVien.Rows[t].Cells[0].Value.ToString();
            txtTenNV.Text = dgvNhanVien.Rows[t].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvNhanVien.Rows[t].Cells[3].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[t].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[t].Cells[5].Value.ToString();
            if (dgvNhanVien.Rows[t].Cells[2].Value.ToString() == "True")
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = true;

            }
        }

        private void FrmQLNhanVien_Load(object sender, EventArgs e)
        {
            loadBang();
        }
        int i = 0;
        private void btnHuy_Click(object sender, EventArgs e)
        {
            i = 0;
            khoaEdit();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            i = 1;
            moEdit();
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
                KetNoiDuLieu.executeQuery("delete from NhanVien where MaNV = '" + dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                loadBang();
            }
            KetNoiDuLieu.closeConnect();
        } 
       
        #endregion

        private void btnChapNhan_Click(object sender, EventArgs e)
        {

            if (i == 1)
            {
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("insert into NhanVien values ('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + radNam.Checked + "','" + Convert.ToDateTime(txtNgaySinh.Text) + "','" + txtSDT.Text + "','"+txtDiaChi.Text+"')");
                loadBang();
                KetNoiDuLieu.closeConnect();
            }
            else
                if (i == 2)
                {
                    KetNoiDuLieu.openConnect();
                    KetNoiDuLieu.executeQuery("update NhanVien set MaNV='" + txtMaNV.Text + "',TenNV='" + txtTenNV.Text + "',Nam='" + radNam.Checked + "',NgaySinh='" + Convert.ToDateTime(txtNgaySinh.Text) + "',SoDienThoai='" + txtSDT.Text + "',DiaChi='"+txtDiaChi.Text+"' where MaNV = '" + dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    loadBang();
                    KetNoiDuLieu.closeConnect();
                }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }
    


 

       

       

    }

}
