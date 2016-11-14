using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace QuanLyCuaHang
{
    class KetNoiDuLieu
    {
        public static string strConnect = @"Server=VANHAY\SQLExpress;Initial Catalog=QLBanHang;Integrated Security=True";
        public static SqlConnection conn = new SqlConnection(strConnect);
        public static void kiemTra()
        {
            try
            {
                conn.Open(); MessageBox.Show("Ket Noi Thanh Cong");
            }
            catch
            {
                MessageBox.Show("Ket Noi That Bai");
            }
        }
        public static void openConnect()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                MessageBox.Show("Ket Noi That Bai");
            }

        }
        public static void closeConnect()
        {
            try
            {
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Ngat Ket Noi That Bai");
            }

        }

        public static DataTable executeLoadData(string sql)
        {
            SqlDataAdapter daData = new SqlDataAdapter(sql, conn);
            DataTable dtData = new DataTable();
            daData.Fill(dtData);
            return dtData;
        }
        public static void executeQuery(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Bị trùng dữ liệu");
            }
        }



    }
}
