using DesignPatterns.Examples.Command_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Command_Pattern
{
    public class Light : ILight
    {
        public void PowerOff()
        {
            Console.WriteLine("Light Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("Light On");
        }
    }
}
