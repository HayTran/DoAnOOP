using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace QuanLyCuaHang
{
    class KiemTraForm
    {
        string textBox;
        public static void kiemTraKhoangTrang(string textBox, string cellCanDien)
        {
            if (textBox == "")
            {
                MessageBox.Show("Bạn cần điền vào Ô " + cellCanDien);
            }
        }
        public static int kiemTraKhoangTrang(string textBox)
        {
            if (textBox == "")
            {
                return 1;
            }
            else return 0;
        }

    }
}
