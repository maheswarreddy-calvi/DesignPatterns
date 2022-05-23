using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        public BaseEmployeeFactory(Employee emp)
        {

        }
        public abstract IEmployeeManager Create();
    }
}
