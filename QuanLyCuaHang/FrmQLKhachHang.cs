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
        int function = 0;
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
      

        private void btnThem_Click(object sender, EventArgs e)
        {
            function = 1;
            moEdit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            function = 2;
            moEdit();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            function = 0;
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
            KhachHang kh = new KhachHang(txtMaKH.Text, txtTenKH.Text, radNam.Checked, txtSDT.Text, txtDiaChi.Text);
            if (function == 1)
            {
                kh.themThongTin();
            }
            else
                if (function == 2)
                {
                    kh.suaThongTin(dgvKhachHang.Rows[dgvKhachHang.CurrentCell.RowIndex].Cells[0].Value.ToString());
                }
            loadBang();
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

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

      
        

        

        

    }
}
