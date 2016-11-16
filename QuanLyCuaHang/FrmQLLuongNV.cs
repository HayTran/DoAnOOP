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
    public partial class FrmQLLuongNV : Form
    {
        public FrmQLLuongNV()
        {
            InitializeComponent();
        }
        int function = 0;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
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
            dgvLuong.DataSource = KetNoiDuLieu.executeLoadData("select * from LuongNV");
            khoaEdit();
        }
        private void QLLuongNV_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            function = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            function = 2;
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            function = 0;
        }

        private void dgvLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvLuong.CurrentCell.RowIndex;
            txtMaNV.Text = dgvLuong.Rows[t].Cells[0].Value.ToString();
            txtLuongCB.Text = dgvLuong.Rows[t].Cells[1].Value.ToString();
            txtSoNgayLam.Text = dgvLuong.Rows[t].Cells[2].Value.ToString();
            txtSoNgayNghi.Text = dgvLuong.Rows[t].Cells[3].Value.ToString();
            txtSoDonHang.Text = dgvLuong.Rows[t].Cells[4].Value.ToString();
            txtTienBanDuoc.Text = dgvLuong.Rows[t].Cells[5].Value.ToString();
            txtTienPhat.Text = dgvLuong.Rows[t].Cells[6].Value.ToString();
            txtTienThuong.Text = dgvLuong.Rows[t].Cells[7].Value.ToString();
            txtThucLinh.Text = dgvLuong.Rows[t].Cells[8].Value.ToString();
            txtThang.Text = dgvLuong.Rows[t].Cells[9].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
