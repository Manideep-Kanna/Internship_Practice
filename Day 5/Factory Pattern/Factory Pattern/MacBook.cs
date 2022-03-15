using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class MacBook:IProducts
    {
        public void Product()
        {
            Console.WriteLine("The items we get are the MacBook and an IPAD");
        }
    }
}
