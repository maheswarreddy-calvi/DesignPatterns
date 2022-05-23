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
    public class DellFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
        }

        public IOs Os()
        {
            return new Windows();
        }
    }
}
