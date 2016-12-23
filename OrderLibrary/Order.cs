using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ItemLibrary;

namespace OrderLibrary
{
    // define the Order class
    // here we have another item information called kiwi, this is for unit testing case
    public class Order
    {
        // indicate whether or not this order has a discount
        public bool _hasDiscount;

        public int _apple_Quantity;
        public int _orange_Quantity;

        //constructor which set whether the order enjoys a discount or not
        // and the quantity of each item in that order

        public Order(bool hasDiscount, int apple_Quantity, int orange_Quantity)
        {
            this._hasDiscount = hasDiscount;
            this._apple_Quantity = apple_Quantity;
            this._orange_Quantity = orange_Quantity;
        }

        //return a list of Item, which could contain Apple or Orange, (or Kiwi for unit testing)
        public List<Item> GetAllItems()
        {
            List<Item> lstItems = new List<Item>();

            for (int i = 0; i < _apple_Quantity; i++)
            {
                Item item = new Apple();
                lstItems.Add(item);
            }

            for (int i = 0; i < _orange_Quantity; i++)
            {
                Item item = new Orange();
                lstItems.Add(item);
            }
            
            return lstItems;
        }
    }
}
