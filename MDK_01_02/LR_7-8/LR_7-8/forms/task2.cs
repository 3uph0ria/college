using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR_7_8.forms
{
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }

        private void task2_MouseClick(object sender, MouseEventArgs e)
        {
            Control element;

            if (e.Location.X < (Size.Width / 2))
            {
                element = new Button() { Text = "Button" };
                element.Size = new Size(75, 23);
            }
            else
            {
                element = new TextBox() { Text = "TextBox" };
                element.Size = new Size(123, 20);
            }

            element.Location = e.Location;
            this.Controls.Add(element);
        }
    }
}
