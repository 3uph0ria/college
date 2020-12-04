using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR_7_8.forms
{
    public partial class task3 : Form
    {
        public task3()
        {
            InitializeComponent();
        }

        private void task3_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Parent = this;
            textBox.Text = "textBox";
            textBox.Location = new Point(e.X, e.Y);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Button";
            btn.Location = new Point(e.X, e.Y);
            panel1.Controls.Add(btn);
        }
    }
}
