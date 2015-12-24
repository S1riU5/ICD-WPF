using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Business.Impl.Factories;
using ICD_WPF.Business.Interface.Factories;
using ICD_WPF.Business.Interface.Models;
using Ninject.Modules;

namespace ICD_WPF.Business.Impl
{
    public class BussinesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IICDFactory>().To<ICDFactory>().InSingletonScope();
            Bind<ISetting>().To<>()
        }
    }
}
