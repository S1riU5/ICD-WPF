using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Data.Impl.Vo
{
    class DataSetVo : IDataSetVo
    {
        public string Code { get; internal set; }
        public string Content { get; internal set; }
    }
}
