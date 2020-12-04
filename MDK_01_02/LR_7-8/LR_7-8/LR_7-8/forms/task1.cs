using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void add_control_Click(object sender, EventArgs e)
        {
            Control ctrl;
            if (rand.Next(0, 11) > 5)
            { 
                ctrl = new Button { Text = "Button" };
            }
            else
            {
                ctrl = new TextBox { Text = "TextBox", AutoSize = true };
            }
            int x = rand.Next(0, this.Size.Width - ctrl.Width);
            int y = rand.Next(0, this.Size.Height - ctrl.Height);
            bool isIntersect = true;
            int displacmentTries = 25;  // количество проверок
            if(displacmentTries == 1)
            {
                x = rand.Next(0, this.Size.Width - ctrl.Width);
                y = rand.Next(0, this.Size.Height - ctrl.Height);
            }
            if (displacmentTries == 0)
            {
                MessageBox.Show("Больше нет места.");
                return;
            }
            ctrl.Location = new Point(x, y);
            this.Controls.Add(ctrl);
            this.Text = "Количество попыток: " +
            (1 - displacmentTries).ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Control ctrl;
            if (rand.Next(0, 11) > 5)
            {
                ctrl = new Button { Text = "Button" };
            }
            else
            {
                ctrl = new TextBox { Text = "TextBox", AutoSize = true };
            }
            int x = rand.Next(0, this.Size.Width - ctrl.Width);
            int y = rand.Next(0, this.Size.Height - ctrl.Height);
            bool isIntersect = true;
            int displacmentTries = 25;  // количество проверок
            if (displacmentTries == 1)
            {
                x = rand.Next(0, this.Size.Width - ctrl.Width);
                y = rand.Next(0, this.Size.Height - ctrl.Height);
            }
            if (displacmentTries == 0)
            {
                MessageBox.Show("Больше нет места.");
                return;
            }
            ctrl.Location = new Point(x, y);
            this.Controls.Add(ctrl);
            this.Text = "Количество попыток: " +
            (1 - displacmentTries).ToString();
        }
    }
}
