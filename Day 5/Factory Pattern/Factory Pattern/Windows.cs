using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Windows:IProducts
    {
        public  void Product()
        {
            Console.WriteLine("Items we get in bag are Windows , Water Bottle and a mouse");
        }
    }
}
