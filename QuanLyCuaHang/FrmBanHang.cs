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
    public partial class FrmBanHang : Form
    {
        public FrmBanHang()
        {
            InitializeComponent(); 

        }
        public FrmQuanLy ql = new FrmQuanLy();
        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            khoiTao();
        }
        private void khoiTao()
        {
            txtMaNV.Text = NhanVien.maNVDangNhap;
            BanHang.khoiTaoHoaDon();
            txtGiamGia.Text = "0";
            radNam.Checked = true;
            txtMaKH.Text = Convert.ToString(BanHang.layMaKhachHang() + 1);
            txtMaDH.Text = Convert.ToString(BanHang.layMaDonHang() + 1);
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtTienKhachPhaiTra.Text = "";
            txtTienKhachDua.Text = "";
            txtTienTraLaiChoKhach.Text = "";
            txtTongTien.Text = "";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtTienKhachDua.Text == "" && txtTienKhachPhaiTra.Text != "") // phòng trường hợp khi xảy ra việc reset, câu nhắc nhở hiện lên
            {
                MessageBox.Show("Vui lòng nhập số tiền!");
            }
            else
            txtTienTraLaiChoKhach.Text = Convert.ToString(BanHang.tinhTienTraLai(txtTienKhachDua.Text, txtTienKhachPhaiTra.Text));
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSoLuongMua.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào số lượng mua!");
            }
            else
            {
                BanHang.taoHoaDon(txtMaMH.Text, txtSoLuongMua.Text);
                txtTongTien.Text = Convert.ToString(BanHang.tinhTongTien());
                txtTienKhachPhaiTra.Text = Convert.ToString(BanHang.tinhTongTienThucTe(txtTongTien.Text, txtGiamGia.Text));
                txtMaMH.Text = "";
                txtSoLuongCon.Text = "";
                txtSoLuongMua.Text = "";
            }
        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {
            MatHang a = new MatHang(txtMaMH.Text);
            txtSoLuongCon.Text = Convert.ToString(a.soLuong);
            txtGiaTien.Text = Convert.ToString(a.giaTien);
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text == "")
                lblDiaChi.Visible = true;
            else
                lblDiaChi.Visible = false;
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "")
                lblTenKH.Visible = true;
            else lblTenKH.Visible = false;
        }
        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
                lblSDT.Visible = true;
            else lblSDT.Visible = false;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các mục ở thông tin khách hàng!");
            }
            else
            {
                KhachHang kH = new KhachHang(txtMaKH.Text, txtTenKH.Text, radNam.Checked, txtSDT.Text, txtDiaChi.Text);
                BanHang.luuDonHang();
                BanHang.luuKhachHang(kH); ;
                MessageBox.Show(BanHang.xuatHoaDon(kH));
                khoiTao();
            }
        }
    }
}
