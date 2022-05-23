using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.SimpleFactory
{
    public class EmployeeFactory
    {
        public IEmployeeManager? GetEmployee(int employeeType)
        {
            IEmployeeManager? employee = null;
            if (employeeType == 1)
                employee = new PermanentEmployee();
            else if (employeeType == 2)
                employee = new ContractEmployee();
            return employee;
        }
    }
}
