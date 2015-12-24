using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Data.Interface.Dao;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Data.Impl.Dao
{

    //TODO Think of how to inject the file into the parser
    class FileReader : IFileReader

    {
        private IParser _parser;
        private string _path;

        public void SetPath(string path)
        {
            _path = path;
        }

        public void SetParser(IParser parser)
        {
            _parser = parser;
        }

        public IEnumerable<IDataSetVo> ReadFile()
        {
            
            return _parser.GetADataSetVos();
        }
    }
}
