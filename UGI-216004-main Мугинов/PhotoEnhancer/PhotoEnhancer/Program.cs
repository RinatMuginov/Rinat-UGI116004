﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
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
