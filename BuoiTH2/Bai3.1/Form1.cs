using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTInh_Click(object sender, EventArgs e)
        {
            double x, f;
            
            x = double.Parse(txtx.Text);

            if ( x >= 2)
            {
                // Math.Pow(cơ_số, số_mũ)
                f = -8 * Math.Pow(x, 3) - 12*x - 1;
            }
            else if (x > 1 && x < 2)
            {
                f = Math.Pow(x, 2) - 6 * x - 19;
            }
            else
            {
                f = 7 * x;
            }
            MessageBox.Show("Giá trị f(x) = "+ f.ToString());
        }
    }
}
