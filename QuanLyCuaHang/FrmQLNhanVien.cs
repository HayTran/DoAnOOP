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
        int function = 0;
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
            txtCMND.Text = dgvNhanVien.Rows[t].Cells[4].Value.ToString();
            txtSDT.Text = dgvNhanVien.Rows[t].Cells[5].Value.ToString();
            txtDiaChi.Text = dgvNhanVien.Rows[t].Cells[6].Value.ToString();
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
       
        private void btnHuy_Click(object sender, EventArgs e)
        {
            function = 0;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtMaNV.Text, txtTenNV.Text, radNam.Checked, txtNgaySinh.Text, txtCMND.Text, txtNgaySinh.Text, txtDiaChi.Text);
            nv.xoaThongTin(dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex].Cells[0].Value.ToString());
            loadBang();
        } 
       
        #endregion

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien(txtMaNV.Text, txtTenNV.Text, radNam.Checked, txtNgaySinh.Text, txtCMND.Text, txtNgaySinh.Text, txtDiaChi.Text);
            if (function == 1)
            {
                nv.themThongTin();
            }
            else
                if (function == 2)
                {
                    int t = dgvNhanVien.CurrentCell.RowIndex;
                    nv.suaThongTin(dgvNhanVien.Rows[t].Cells[0].Value.ToString());
                }
            loadBang();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    


 

       

       

    }

}
