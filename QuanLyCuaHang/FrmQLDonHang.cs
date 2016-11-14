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
    public partial class FrmQLDonHang : Form
    {
        public FrmQLDonHang()
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoiDuLieu.openConnect();
            DialogResult = MessageBox.Show("Ban co muon xoa khong?", "Thong bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from DonHang where MaDH = '" + dgvDonHang.Rows[dgvDonHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                loadBang();
            }
            KetNoiDuLieu.closeConnect();

        }
        private void loadBang()
        {
            dgvDonHang.DataSource = KetNoiDuLieu.executeLoadData("select * from DonHang");
            khoaEdit();
        }
        #endregion
        private void FrmQLDonHang_Load(object sender, EventArgs e)
        {
            loadBang();
        }
       

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("insert into DonHang values ('"+txtMaDH.Text+"','"+txtMaKH.Text+"','"+int.Parse(txtTienDH.Text)+"','"+Convert.ToDateTime(txtNgayXuatDH.Text)+"','"+txtMaNV.Text+"')");
                loadBang();
                KetNoiDuLieu.closeConnect();
            }
            else
                if (i == 2)
                {
                    KetNoiDuLieu.openConnect();
                    KetNoiDuLieu.executeQuery("update DonHang set MaDH='" + txtMaDH.Text + "',MaKH='" + txtMaKH.Text + "',TienDH='" + int.Parse(txtTienDH.Text) + "',NgayXuatDH='" + Convert.ToDateTime(txtNgayXuatDH.Text) + "', MaNV = '"+txtMaNV.Text+"' where MaDH = '" + dgvDonHang.Rows[dgvDonHang.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    loadBang();
                    KetNoiDuLieu.closeConnect();
                }
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvDonHang.CurrentCell.RowIndex;
            txtMaDH.Text = dgvDonHang.Rows[t].Cells[0].Value.ToString();
            txtMaKH.Text = dgvDonHang.Rows[t].Cells[1].Value.ToString();
            txtTienDH.Text = dgvDonHang.Rows[t].Cells[2].Value.ToString();
            txtNgayXuatDH.Text = dgvDonHang.Rows[t].Cells[3].Value.ToString();
            txtMaNV.Text = dgvDonHang.Rows[t].Cells[4].Value.ToString();
        }

      
    }
}
