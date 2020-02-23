using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using ABCVEN.Interfaces;
using ABCVEN.BLL;

namespace ABCVEN
{
    public class NinjectRegistrations:NinjectModule
    {
        public override void Load()
        {
            Bind<IFileUploadService>().To<FileUploadService>();
        }
    }
}
