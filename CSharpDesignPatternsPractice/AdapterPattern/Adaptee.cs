﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDesignPatternsPractice.AdapterPattern
{
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request";
        }
  
    }
}
