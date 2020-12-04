using LR_7_8.forms;
using System;
using System.Windows.Forms;

namespace LR_7_8
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new task3());
        }
    }
}
