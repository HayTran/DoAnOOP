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
    public partial class FrmQLKhachHang : Form
    {
        public FrmQLKhachHang()
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
            dgvKhachHang.DataSource = KetNoiDuLieu.executeLoadData("select * from KhachHang");
            khoaEdit();
        }

        private void FrmQLKhachHang_Load(object sender, EventArgs e)
        {
            loadBang();
            khoaEdit();
        }
        int i = 0;

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
        private void btnHuy_Click(object sender, EventArgs e)
        {
            i = 0;
            khoaEdit();
        }

     
        #endregion

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[t].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKhachHang.Rows[t].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhachHang.Rows[t].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[t].Cells[4].Value.ToString();
            if (dgvKhachHang.Rows[t].Cells[2].Value.ToString() == "True")
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

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("insert into KhachHang values ('" + txtMaKH.Text + "','" + txtTenKH.Text + "','" + radNam.Checked + "','" + txtSDT.Text + "','" + txtDiaChi.Text + "')");
                loadBang();
                KetNoiDuLieu.closeConnect();
            }
            else
                if (i == 2)
                {
                    KetNoiDuLieu.openConnect();
                    KetNoiDuLieu.executeQuery("update KhachHang set MaKH='" + txtMaKH.Text + "',TenKH='" + txtTenKH.Text + "',Nam='" + radNam.Checked + "',SoDienThoai='" + txtSDT.Text + "',DiaChi='" + txtDiaChi.Text + "' where MaKH = '" + dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    loadBang();
                    KetNoiDuLieu.closeConnect();
                }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoiDuLieu.openConnect();
            DialogResult = MessageBox.Show("Ban co muon xoa khong?", "Thong bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from KhachHang where MaKH = '" + dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                loadBang();
            }
            KetNoiDuLieu.closeConnect();
        }

      
        

        

        

    }
}
