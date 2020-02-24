using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using ABCVEN.Interfaces;
using ABCVEN.BLL;
using ABCVEN.Data;

namespace ABCVEN
{
    public class NinjectRegistrations:NinjectModule
    {
        public override void Load()
        {
            Bind<IFileUploadService>().To<FileUploadService>();
            Bind<ABCVENContext>().To<ABCVENContext>();
            Bind<ICrudService>().To<CrudService>();
        }
    }
}
