using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Facade_Pattern
{
    public class OrderService
    {
        public void OrderProdcut(string productName)
        {
            new Product().GetProduct(productName);
            new Address().GetAddress();
            new EkartLogistics().DeliveryAvailability();
            new MerchentNotifier().Notify();

            Console.WriteLine("Order placed");
        }
    }
}
