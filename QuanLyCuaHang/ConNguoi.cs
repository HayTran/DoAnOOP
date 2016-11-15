using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuanLyCuaHang
{
    public abstract class ConNguoi
    {
        public string maSo;
        public string hoTen;
        public bool gioiTinh;
        public string soDienThoai;
        public string diaChi;
        public abstract void themThongTin();
        public abstract void suaThongTin(string currentCell);
        public abstract void xoaThongTin(string currentCell);
        public int kiemTraTrungDuLieu(string tenBang, string tenCot, string maSo)
        {
            KetNoiDuLieu.openConnect();
            DataTable dt = new DataTable();
            dt = KetNoiDuLieu.executeLoadData("select * from '"+tenBang+"' where '"+tenCot+"' = '" + maSo + "'");
            KetNoiDuLieu.closeConnect();
            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
