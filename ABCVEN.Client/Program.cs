﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABCVEN.Interfaces;
using Ninject;
using Ninject.Modules;


namespace ABCVEN
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

            var registrations = new NinjectRegistrations();
            var kernel = new StandardKernel(registrations);
            var dep = kernel.Get<IFileUploadService>();
            Application.Run(new Form1(dep));
        }
    }
}
