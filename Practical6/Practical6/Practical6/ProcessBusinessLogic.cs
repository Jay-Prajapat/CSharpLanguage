﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    public delegate void Notify();
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
