using DesignPatterns.Examples.Abstrct_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Abstrct_Factory.Os
{
    public class Windows : IOs
    {
        public string GetOS()
        {
            return "Windows";
        }
    }
}
