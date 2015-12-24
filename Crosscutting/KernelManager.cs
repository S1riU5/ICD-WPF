﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Crosscutting
{
    public class KernelManager
    {
         #region Fields

        private static readonly KernelManager Kernel = new KernelManager();
        private readonly StandardKernel _standardKernel;

        #endregion

        #region Singleton

        public static KernelManager Instance
        {
            get { return Kernel; }
        }

        private KernelManager()
        {
            _standardKernel = new StandardKernel();
            _standardKernel.Load("ICD-WPF.*.dll");
        }

        #endregion

        #region API

        public IKernel GetKernel()
        {
            return _standardKernel;
        }

        #endregion
    }
}
