using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_5_6.forms
{
    public partial class task4 : Form
    {
        public task4()
        {
            InitializeComponent();
        }

        private void button_result_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(input_x0.Text);
            double xk = Convert.ToDouble(input_xk.Text);
            double dx = Convert.ToDouble(input_dx.Text);
            double a = Convert.ToDouble(input_a.Text);
            result.Text = "Работу выполнил ст. Саломатин С.В." + Environment.NewLine;

            double x = x0;

            while (x <= (xk + dx / 2))
            {
                double y = x * Math.Sin(Math.Sqrt(x + a - 0.0084));
                result.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;

                // x × sin( x + b - 0.0084)
            }
        }
    }
}
