using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrary
{
    public class Apple : Item
    {
        // constructor which set its name("Apple") and its price("$0.45")
        public Apple()
        {
            this.Name = "Apple";
            this.Price = 0.45m;
        }
    }
}
