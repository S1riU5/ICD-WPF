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
        private IEnumerable<IDataSetVo> dataSetVos; 

        public IEnumerable<IDataSetVo> GetADataSetVos()
        {
            return dataSetVos;
        }

        public void SetIcdText(string icdText)
        {
            _icdText = icdText;
        }

        private IEnumerable<IDataSetVo> ParsIcdText(string icdText)
        {
            IEnumerable<IDataSetVo> icdCatalog = new List<IDataSetVo>();
            
            //TODO Splitt text by LZ
            //TODO Fillter for content



            return icdCatalog;
        } 
    }
}
