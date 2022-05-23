using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory Create(Employee emp)
        {
            if(emp.EmployeeType == 1)
            {
                return new PermanentEmployeFactory(emp);
            }
            if (emp.EmployeeType == 2)
            {
                return new ContractEmployeeFactory(emp);
            }
            return null;
        }
    }
}
