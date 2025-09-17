using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
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

        private void txtNam_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);
            double c = double.Parse(txtc.Text);

            if (a == 0)
            {
                txtKetQua.Text = b == 0 ? (c == 0 ? "Vô số nghiệm" : "Vô nghiệm")
                                    : $"PT bậc 1: x = {-c / b}";
            }
            else
            {
                double d = b * b - 4 * a * c;
                if (d < 0) txtKetQua.Text = "Vô nghiệm thực";
                else if (d == 0) txtKetQua.Text = $"Nghiệm kép: x = {-b / (2 * a)}";
                else txtKetQua.Text = $"x1 = {(-b + Math.Sqrt(d)) / (2 * a)}; x2 = {(-b - Math.Sqrt(d)) / (2 * a)}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

