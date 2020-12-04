using System;
using System.Windows.Forms;

namespace LR_5_6.forms
{
    public partial class task3 : Form
    {
        public task3()
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
                double y = 9 * (x + 15 * Math.Sqrt(Math.Pow(x, 3) + Math.Pow(a, 3)));
                result.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;

                // 9x4 + sin(57.2 + x),
            }
        }
    }
}
