using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.FactoryMethod
{
    public class PermanentEmployeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            return new PermanentEmployee();
        }
    }
}
