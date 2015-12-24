using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD_WPF.Business.Interface.Models
{
    public interface ISetting
    {
        string FileName { get; set; }

        event EventHandler SettingChanged;
    }
}
