using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR_7_8
{
    public partial class task1 : Form
    {
        Random rand = new Random();
        public task1()
        {
            InitializeComponent();
        }

        private void task1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Button btn = new Button();
                this.Controls.Add(btn);
                btn.Location = new Point(e.X, e.Y);
                btn.Text = string.Format("{0}, {1}", e.X, e.Y);
            }
        }
    }
}
