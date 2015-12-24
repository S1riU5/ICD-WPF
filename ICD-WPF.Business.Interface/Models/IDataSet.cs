using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD_WPF.Business.Interface.Models
{
    public interface IDataSet
    {
        string Content { get; }
        string Code { get; }
    }
}
