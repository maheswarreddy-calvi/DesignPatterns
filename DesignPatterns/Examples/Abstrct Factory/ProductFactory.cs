using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Abstrct_Factory
{
    internal class ProductFactory
    {

        public IComputerFactory GetProduct(bool isWindows)
        {
            if (isWindows)
            {
                return new DellFactory();
            }
            return new MacFactory();
        }
    }
}
