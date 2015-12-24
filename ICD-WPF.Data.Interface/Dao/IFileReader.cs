using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Data.Interface.Vo;

namespace ICD_WPF.Data.Interface.Dao
{
    public interface IFileReader
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        void SetPath(string path);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parser"></param>
        void SetParser(IParser parser);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<IDataSetVo> ReadFile();
    }
}
