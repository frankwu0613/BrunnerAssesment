using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLibrary
{
    public class Kiwi : Item
    {
        // constructor which set its name("Kiwi") and its price("$0.95")
        // this is for unit testing case
        public Kiwi()
        {
            this.Name = "Kiwi";
            this.Price = 0.45m;
        }
    }
}
