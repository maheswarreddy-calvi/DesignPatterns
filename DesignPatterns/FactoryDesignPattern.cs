using DesignPatterns.Models;

namespace DesignPatterns
{
    public class FactoryDesignPattern
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
