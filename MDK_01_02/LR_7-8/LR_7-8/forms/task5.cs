using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR_7_8.forms
{
    public partial class task5 : Form
    {
        Random random = new Random();
        public task5()
        {
            InitializeComponent();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Label label = new Label();
            int locationX = random.Next(0, 200);
            int locationY = random.Next(0, 150);
            label.Location = new Point(locationX, locationY);
            label.Text = "Label";
            panel1.Controls.Add(label);
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = new TextBox();
            int locationX = random.Next(0, 200);
            int locationY = random.Next(0, 150);
            textBox.Location = new Point(locationX, locationY);
            textBox.Text = "TextBox";
            panel3.Controls.Add(textBox);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = new Button();
            int locationX = random.Next(0, 200);
            int locationY = random.Next(0, 150);
            button.Location = new Point(locationX, locationY);
            button.Text = "button";
            panel2.Controls.Add(button);
        }
    }
}
