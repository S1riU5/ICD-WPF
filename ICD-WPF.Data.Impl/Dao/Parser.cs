using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Data.Interface.Dao;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Data.Impl.Dao
{
    class Parser : IParser
    {

        private string _icdText;

        public IEnumerable<IDataSetVo> GetADataSetVos()
        {
            throw new NotImplementedException();
        }

        public void SetIcdText(string icdText)
        {
            _icdText = icdText;
        }
    }
}
