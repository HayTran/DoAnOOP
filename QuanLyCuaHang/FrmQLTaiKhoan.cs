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
    public partial class FrmQLTaiKhoan : Form
    {
        public FrmQLTaiKhoan()
        {
            InitializeComponent();
        }
        #region
        int i = 0;
        private void moEdit()
        {
            btnChapNhan.Enabled = true;
            btnHuy.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }
        private void khoaEdit()
        {
            btnChapNhan.Enabled = false;
            btnHuy.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            KetNoiDuLieu.openConnect();
            DialogResult = MessageBox.Show("Ban co muon xoa khong?", "Thong bao ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                KetNoiDuLieu.executeQuery("delete from TaiKhoan where MaNV = '" + dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                loadBang();
            }
            KetNoiDuLieu.closeConnect();
        }
       
        private void loadBang()
        {
            dgvTaiKhoan.DataSource = KetNoiDuLieu.executeLoadData ("select * from TaiKhoan");
            khoaEdit();
        }
        private void FrmQLTaiKhoan_Load(object sender, EventArgs e)
        {
            loadBang();
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
        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvTaiKhoan.CurrentCell.RowIndex;
            txtMaNV.Text = dgvTaiKhoan.Rows[t].Cells[0].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[t].Cells[1].Value.ToString();
         if (dgvTaiKhoan.Rows[t].Cells[2].Value.ToString() == "True")
            {
                chkAdmin.CheckState = CheckState.Checked;
            }
            else chkAdmin.CheckState = CheckState.Unchecked;
          }
        #endregion
        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                KetNoiDuLieu.openConnect();
                KetNoiDuLieu.executeQuery("insert into TaiKhoan values('" + txtMaNV.Text + "','" + txtMatKhau.Text + "','" + chkAdmin.Checked + "')");
                loadBang();
                KetNoiDuLieu.closeConnect();
            }
            else
                if (i == 2)
                { 
                    KetNoiDuLieu.openConnect();
                    KetNoiDuLieu.executeQuery("update TaiKhoan set MaNV='" + txtMaNV.Text + "',MatKhau='" + txtMatKhau.Text + "',Admin ='" + chkAdmin.Checked + "' where MaNV ='" + dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                    loadBang();
                    KetNoiDuLieu.closeConnect();
                }
            loadBang();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            i = 0;
            khoaEdit();
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
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
