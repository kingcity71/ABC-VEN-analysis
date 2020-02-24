using System;
using System.Windows.Forms;
using ABCVEN.BLL;
using ABCVEN.Data;
using ABCVEN.Interfaces;
using ABCVEN.Models;
using SimpleInjector;
using SimpleInjector.Lifestyles;


namespace ABCVEN
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            using(ThreadScopedLifestyle.BeginScope(container))
                Application.Run(container.GetInstance<Form1>());
        }
        static void Bootstrap()
        {
            container = new Container();
            container.Options.DefaultScopedLifestyle =  new ThreadScopedLifestyle();
            container.Register<ABCVENContext>(Lifestyle.Scoped);
            container.Register<IFileUploadService, FileUploadService>(Lifestyle.Scoped);
            container.Register<ICrudService, CrudService>(Lifestyle.Scoped);
            container.Register<ICalculationService, CalculationService>(Lifestyle.Scoped);
            container.Register<IViewService, ViewService>(Lifestyle.Scoped);
            container.Register<Form1>(Lifestyle.Scoped);

            container.Verify();
        }
    }
}
