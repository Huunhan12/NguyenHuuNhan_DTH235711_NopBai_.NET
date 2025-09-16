using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            // 1. Đọc và kiểm tra nhập
            if (!int.TryParse(txtNgay.Text.Trim(), out int Ngay) || 
               !int.TryParse(txtThang.Text.Trim(), out int Thang) || 
               !int.TryParse(txtNam.Text.Trim(), out int Nam))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho ngày, tháng và năm.");
                return;
            }
            // 2. Kiểm tra phạm vi tháng và năm cơ bản
            if (Thang < 1 || Thang > 12 || Nam < 1)
            {
                MessageBox.Show("Tháng phải trong khoảng 1-12 và Năm phải >= 1.", "Không hợp lệ");
                return;
            }
            // 3. Kiểm tra năm nhuận
            bool isLeap = (Nam % 400 == 0) || (Nam % 4 == 0 && Nam % 100 != 0);

            // 4. Xác định số ngày lớn nhất trong tháng
            int maxNgay;
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    maxNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxNgay = 30;
                    break;
                case 2:
                    maxNgay = isLeap ? 29 : 28;
                    break;
                default:
                    maxNgay = 0; // không xảy ra vì đã kiểm tra thang
                    break;
            }

            // 5. So sánh ngày
            if (Ngay >= 1 && Ngay <= maxNgay)
            {
                MessageBox.Show("Ngày hợp lệ!", "Kết quả");
            }
            else
            {
                MessageBox.Show("Ngày KHÔNG hợp lệ!", "Kết quả");
            }
        }

    }
}

