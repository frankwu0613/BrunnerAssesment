using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrary;
using OrderLibrary;

namespace Brunner.Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many apples do you want ?");
            int numApple = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many oranges do you want ?");
            int numOrange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Does this order contains a discount ? (1 for yes, 0 for no)" );
            int flag = Convert.ToInt32(Console.ReadLine());

            bool discount = flag == 1 ? true : false;

            // create a new order, with discount information, and each number of items
            Order order = new Order(discount, numApple, numOrange); 


            Console.WriteLine("The total price for this order is : {0}", 
                Pricing.GetTotalValue(order).ToString());
            Console.ReadKey();

        }
    }
}
