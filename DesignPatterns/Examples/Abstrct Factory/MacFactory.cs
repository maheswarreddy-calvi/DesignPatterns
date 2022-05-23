using DesignPatterns.Examples.Abstrct_Factory.Brands;
using DesignPatterns.Examples.Abstrct_Factory.Interfaces;
using DesignPatterns.Examples.Abstrct_Factory.Os;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Abstrct_Factory
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Mac();
        }

        public IOs Os()
        {
            return new MacOs();
        }
    }
}
