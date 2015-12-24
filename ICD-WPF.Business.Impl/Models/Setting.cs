using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICD_WPF.Business.Impl.Helpers;
using ICD_WPF.Business.Interface.Models;

namespace ICD_WPF.Business.Impl.Models
{
                
    public class Setting: ObjectNotifyPropertyChanged, ISetting
    {
        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                OnSettingsChanged(new EventArgs());
                OnPropertyChanged(() => FileName);
            }
        }

        public Setting()
        {
            _fileName = @"../../res/icd10gm2014syst_edvascii_20130920.txt";
        }

        #region events

        public event EventHandler SettingChanged;

        protected void OnSettingsChanged(EventArgs args)
        {
            var handler = SettingChanged;
            if (handler != null)
            {
                handler(this, args);
            }
        } 

        #endregion


    }
}
