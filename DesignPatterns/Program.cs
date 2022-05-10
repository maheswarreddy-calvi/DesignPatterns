// See https://aka.ms/new-console-template for more information
using DesignPatterns;

Console.WriteLine("Hello, World!");

//Parallel.Invoke(() => SingletonThread1(),
//    () => SingletonThread2());

Console.ReadLine();

void SingletonThread1()
{
    SingletonDesignPattern obj = SingletonDesignPattern.getInstance();
    obj.Print();
}


void SingletonThread2()
{
    SingletonDesignPattern obj = SingletonDesignPattern.getInstance();
    obj.Print();
}

