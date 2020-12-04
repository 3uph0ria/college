using System;
using System.Windows.Forms;

namespace LR_5_6
{
    public partial class Form1 : Form
    {
        public Form1()
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
                double y = 0.00084 * ((Math.Pow(Math.Log(Math.Abs(x)), 5 / 4) + a) / (Math.Pow(x, 2) + 3.82));
                result.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
