using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Business.Interface.Models;

namespace ICD_WPF.Business.Interface.Factories
{
    public interface IICDFactory
    {
        IEnumerable<IDataSet> GetDataSets();
    }
}
