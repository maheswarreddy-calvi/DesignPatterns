using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EmployeeType { get; set; }

        public int Bonus { get; set; }

        public int WorkingHours { get; set; }

        public int HouseRent { get; set; }
    }
}
