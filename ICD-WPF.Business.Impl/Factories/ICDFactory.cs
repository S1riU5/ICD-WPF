using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Business.Impl.Models;
using ICD_WPF.Business.Interface.Factories;
using ICD_WPF.Business.Interface.Models;
using ICD_WPF.Data.Interface.Dao;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Business.Impl.Factories
{
    public class ICDFactory : IICDFactory
    {

        #region Fields

        private readonly IFileReader _fileReader;
        private readonly IParser _parser;
        private readonly ISetting _setting;
        private IEnumerable<IDataSet> _dataSets;

        #endregion

        public ICDFactory(IFileReader fileReader,IParser parser, ISetting setting)
        {
            _fileReader = fileReader;
            _parser = parser;
            _setting = setting;
        }

        public IEnumerable<IDataSet> GetDataSets()
        {
            _fileReader.SetPath(_setting.FileName);
            _fileReader.SetParser(_parser);

            var data = _fileReader.ReadFile();

            var result = data.Select(d => new DataSet
            {
                Code = d.Code,
                Content = d.Content
            });

            return result;
        }
    }
}
