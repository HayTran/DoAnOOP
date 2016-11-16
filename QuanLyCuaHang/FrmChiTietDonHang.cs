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
    public partial class FrmChiTietDonHang : Form
    {
        public FrmChiTietDonHang()
        {
            InitializeComponent();
        }
        private void loadBang()
        {
            dgvChiTietDonHang.DataSource = KetNoiDuLieu.executeLoadData("select * from ChiTietDonHang");
        }
      
        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvChiTietDonHang.CurrentCell.RowIndex;
            txtMaDH.Text = dgvChiTietDonHang.Rows[t].Cells[0].Value.ToString();
            txtMaMH.Text = dgvChiTietDonHang.Rows[t].Cells[1].Value.ToString();
            txtTenMH.Text = dgvChiTietDonHang.Rows[t].Cells[2].Value.ToString();
            txtGiaBan.Text = dgvChiTietDonHang.Rows[t].Cells[3].Value.ToString();
            txtSoLuong.Text = dgvChiTietDonHang.Rows[t].Cells[4].Value.ToString();
        }

        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            loadBang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

       
    }
}
