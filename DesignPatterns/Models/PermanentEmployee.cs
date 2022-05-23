using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class PermanentEmployee : IEmployeeManager
    {
        public int GetBonus()
        {
            return 10;
        }

        public int GetWorkingHours()
        {
            return 8;
        }
    }
}
