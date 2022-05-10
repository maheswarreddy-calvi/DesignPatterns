using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class SingletonDesignPattern
    {
        private static int id = 0;
        private static SingletonDesignPattern obj;

        private SingletonDesignPattern()
        {
            id++;
        }

        public static SingletonDesignPattern getInstance()
        {
            if (obj == null)
            {
                obj = new SingletonDesignPattern();
            }
            return obj;
        }

        public void Print()
        {
            Console.WriteLine($"Value {id}");
        }
    }
}
