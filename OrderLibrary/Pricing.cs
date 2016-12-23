using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrary;

namespace OrderLibrary
{
    public class Pricing
    {
        // a static method, which takes the order object as parameter
        // and return total value of the order
        public static decimal GetTotalValue(Order order)
        {
            //if there is no order, throw an exception
            if (order == null)
            {
                throw new NullReferenceException("No order available");
            }

            // initilization
            int countApple = 0;
            int countOrange = 0;
            decimal appleValue = 0.0m;
            decimal orangeValue = 0.0m;
            decimal totalValue = 0.0m;

            foreach (var item in order.GetAllItems())
            {

                if (item.Name == "Apple")
                {
                    countApple++; // count the number of apples in the order
                }
                else if (item.Name == "Orange")
                {
                    countOrange++; // count the number of oranges in the order
                }
                else
                {
                    throw new Exception("Wrong item in the cart!");
                    // if there is an item neither "Apple" nor "Orange", throw an exception
                }
            }

            // get the total value based on whether there is a discount or not
            if (order._hasDiscount)
            {
                if (countApple % 2 == 0)
                {
                    appleValue = (new Apple()).Price 
                        * Convert.ToDecimal(countApple / 2);
                }
                else
                {
                    appleValue = (new Apple()).Price
                        * Convert.ToDecimal(countApple / 2) + (new Apple()).Price;
                }

                if (countOrange % 3 == 0)
                {
                    orangeValue = (new Orange()).Price 
                        * Convert.ToDecimal(countOrange * 2 / 3);
                }
                else if (countOrange % 3 == 1)
                {
                    orangeValue = (new Orange()).Price
                        * Convert.ToDecimal(countOrange * 2 / 3)
                        + (new Orange()).Price;
                }
                else
                {
                    orangeValue = (new Orange()).Price
                        * Convert.ToDecimal(countOrange * 2 / 3)
                        + (new Orange()).Price * 2;
                }

            }
            else
            {
                appleValue = (new Apple()).Price * Convert.ToDecimal(countApple);
                orangeValue = (new Orange()).Price * Convert.ToDecimal(countOrange);
            }

            totalValue = appleValue + orangeValue;

            return totalValue;
        }
    }
}
