using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    //    public sealed class SingletonDesignPattern
    //    {
    //        private static int id = 0;
    //        //  private static SingletonDesignPattern obj;
    //        private static readonly Lazy<SingletonDesignPattern> obj =
    //                new Lazy<SingletonDesignPattern>(() => new SingletonDesignPattern());

    //        private SingletonDesignPattern()
    //        {
    //            id++;
    //        }

    //        public static SingletonDesignPattern getInstance()
    //        {
    //            //if (obj == null)
    //            //{
    //            //    obj = new SingletonDesignPattern();
    //            //}
    //            return obj.Value;
    //        }

    //        public void Print()
    //        {
    //            Console.WriteLine($"Value {id}");
    //        }
    //    }


    public class SingletonPattern
    {
        private static int id;
        private static readonly SingletonPattern? obj = new SingletonPattern();
        private SingletonPattern()
        {
            id = id + 1;
        }
        public static SingletonPattern GetInstance()
        {
            return obj;
        }

        public void Print()
        {
            Console.WriteLine($"Value {id}");
        }

    }
}
