using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrary
{
    //define the Item class, which contains Name and Price properties
    // Apple and Orange will inherit this class
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
