using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            int Thang;
            if (!int.TryParse(txtThang.Text, out Thang))
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 1 đến 12");
                return;
            }
            string mua;
            if (Thang == 1 || Thang == 2 || Thang == 3)
            {
                mua = "Mùa Xuân";
            }
            else if (Thang == 4 || Thang == 5 || Thang == 6)
            {
                mua = "Mùa Hạ";
            }
            else if (Thang == 7 || Thang == 8 || Thang == 9)
            {
                mua = "Mùa Thu";
            }
            else if (Thang == 10 || Thang == 11 || Thang == 12)
            {
                mua = "Mùa Đông";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số nguyên từ 1 đến 12");
                return;
            }
            MessageBox.Show("Tháng " + Thang + " là " + mua);
        }
    }
}
