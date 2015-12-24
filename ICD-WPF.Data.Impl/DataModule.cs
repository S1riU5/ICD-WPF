using ICD_WPF.Data.Impl.Dao;
using ICD_WPF.Data.Impl.Vo;
using ICD_WPF.Data.Interface.Dao;
using ICD_WPF.Data.Interface.Vo;
using Ninject.Modules;

namespace ICD_WPF.Data.Impl
{
    public class DataModule: NinjectModule
    {
        public override void Load()
        {
            // Vo's 
            Bind<IDataSetVo>().To<DataSetVo>();

            //Dao's
            Bind<IParser>().To<Parser>().InSingletonScope();

            Bind<IFileReader>().To<FileReader>().InSingletonScope();
        }
    }
}
