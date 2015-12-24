using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICD_WPF.View.ViewModel
{
    public class ViewModelManager
    {
        private static readonly ViewModelManager _ViewModelManager = new ViewModelManager();

        private ViewModelManager() { }

        public static ViewModelManager Instance
        {
            get { return _ViewModelManager; }
        }
    }
}
