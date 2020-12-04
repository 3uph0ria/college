using System;
using System.Windows.Forms;

namespace LR_5_6.forms
{
    public partial class task2 : Form
    {
        public task2()
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
                double y = x * 4 + Math.Cos(2 + x * 3 - a);
                result.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
