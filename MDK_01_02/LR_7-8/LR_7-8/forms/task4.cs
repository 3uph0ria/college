using System;
using System.Drawing;
using System.Windows.Forms;

namespace LR_7_8.forms
{
    public partial class task4 : Form
    {
        Random random = new Random();
        public task4()
        {
            InitializeComponent();
        }

        private void add_item_form_Click(object sender, EventArgs e)
        {
            int rand = random.Next(1, 3);
            if (rand == 1)
            {
                int locationX = random.Next(0, 800);
                int locationY = random.Next(0, 400);
                Button button = new Button();
                button.Text = "button";
                button.Location = new Point(locationX, locationY);
                Controls.Add(button);
                logs.Text += "На форму добавлен элемент Button расположение: X - " + locationX + "; Y - " + locationY + "\n\r";
            }
            else if (rand == 2)
            {
                int locationX = random.Next(0, 800);
                int locationY = random.Next(0, 400);
                TextBox textBox = new TextBox();
                textBox.Text = "textBox";
                textBox.Location = new Point(locationX, locationY);
                Controls.Add(textBox);
                logs.Text += "На форму добавлен элемент TextBox расположение: X - " + locationX + "; Y - " + locationY + "\n\r";
            }
        }

        private void add_item_panel_Click(object sender, EventArgs e)
        {
            int rand = random.Next(1, 3);
            if (rand == 1)
            {
                int locationX = random.Next(0, 250);
                int locationY = random.Next(0, 250);
                Button button = new Button();
                button.Text = "button";
                button.Location = new Point(locationX, locationY);
                panel.Controls.Add(button);
                logs.Text += "На панель добавлен элемент Button расположение: X - " + locationX + "; Y - " + locationY + "\n\r";
            }
            else if (rand == 2)
            {
                int locationX = random.Next(0, 250);
                int locationY = random.Next(0, 250);
                TextBox textBox = new TextBox();
                textBox.Text = "textBox";
                textBox.Location = new Point(locationX, locationY);
                panel.Controls.Add(textBox);
                logs.Text += "На панель добавлен элемент TextBox расположение: X - " + locationX + "; Y - " + locationY + "\n\r";
            }
        }
    }
}
