using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Facade_Pattern
{
    public class Product
    {
        public void GetProduct(string productName)
        {
            Console.WriteLine("Get product info");
        }
    }
}
