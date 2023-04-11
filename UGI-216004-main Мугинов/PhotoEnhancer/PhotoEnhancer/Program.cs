using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var p = new Pixel(0.8, 0.7, 0.2);
            var p2 = Convertors.HSLToPixel(p.H, p.S, p.L);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = new MainForm();

            mainForm.AddFilter(new LighteningFilter());
            mainForm.AddFilter(new GrayScaleFilter());
            mainForm.AddFilter(new SepiaFilter());

            Application.Run(mainForm);
        }
    }
}
