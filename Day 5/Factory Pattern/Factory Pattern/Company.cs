using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Company
    {
        public IProducts getProduct(IProducts product)
        {
            return new IProducts();
            return null;
        }
    }
}
