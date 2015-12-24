using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Data.Interface.Dao
{
    public interface IParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<IDataSetVo> GetADataSetVos();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="icdText"></param>
        void SetIcdText(string icdText);

    }
}
