using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrary
{
    public class Orange : Item
    {
        // constructor which set its name("Orange") and its price("$0.65")
        public Orange()
        {
            this.Name = "Orange";
            this.Price = 0.65m;
        }
    }
}
