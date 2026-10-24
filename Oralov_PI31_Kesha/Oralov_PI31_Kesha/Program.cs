using System;
using System.Windows.Forms;

namespace Oralov_PI31_Kesha
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Инициализация для .NET 5 (классический стиль)
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запуск вашей формы
            Application.Run(new MainForm());
        }
    }
}