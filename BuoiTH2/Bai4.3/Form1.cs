using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtn.Text);
            double s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += 1.0 / i;
            }
            txts.Text = s.ToString();
        }

        private void txts_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
