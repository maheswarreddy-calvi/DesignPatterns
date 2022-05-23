// See https://aka.ms/new-console-template for more information
using DesignPatterns;
using DesignPatterns.Examples.Abstrct_Factory;
using DesignPatterns.Examples.Command_Pattern;
using DesignPatterns.Examples.Command_Pattern.Commands;
using DesignPatterns.Examples.Command_Pattern.Interfaces;
using DesignPatterns.Examples.Facade_Pattern;
using DesignPatterns.Examples.SimpleFactory;
using DesignPatterns.Models;

Console.WriteLine("Hello, World!");


/// --------------------------
/// <summary>
///  Singleton Pattern
/// </summary>
/// --------------------------
//Parallel.Invoke(() => SingletonThread1(),
//    () => SingletonThread2());

//Console.ReadLine();

//void SingletonThread1()
//{
//    SingletonPattern obj = SingletonPattern.GetInstance();
//    obj.Print();
//}


//void SingletonThread2()
//{
//    SingletonPattern obj = SingletonPattern.GetInstance();
//    obj.Print();
//}
/// --------------------------
/// <summary>
///  Simple Factory Pattern
/// </summary>   
/// --------------------------
/// 
//var employeeObj = new Employee { Id = 1, Name = "Hari", EmployeeType = 1 };

//IEmployeeManager? employee = new EmployeeFactory().GetEmployee(employeeObj.EmployeeType);
//Console.WriteLine(employee.GetBonus());


/// --------------------------
/// <summary>
///  Factory Method Pattern
/// </summary>   
/// --------------------------
/// 
//var employeeObj = new Employee { Id = 1, Name = "Hari", EmployeeType = 1 };

//IEmployeeManager? employee = new EmployeeFactory().GetEmployee(employeeObj.EmployeeType);
//Console.WriteLine(employee.GetBonus());

//TODO : 25/05/2022
//*******/****Abstract Factory Pattern************///
ProductFactory productObj = new ProductFactory();
var product = productObj.GetProduct(true);
Console.WriteLine(product.Brand().GetBrandName());
Console.WriteLine(product.Os().GetOS());
Console.WriteLine("--------------");
//************Command Pattern************///
ILight lamp = new Light();
Switch obj = new Switch(new SwitchOnCommand(lamp),new SwitchOffCommand(lamp));
obj.SwitchOn();
obj.SwitchOff();
Console.WriteLine("--------------");
var phoneObj = new SmartPhoneApp(new SwitchOnCommand(lamp), new SwitchOffCommand(lamp),new AutoSwitchOffCommand(lamp));
phoneObj.SwitchOn();
phoneObj.AutoSwitchOff();
Console.WriteLine("--------------");
//************Facade Pattern************///
new OrderService().OrderProdcut("Laptop");