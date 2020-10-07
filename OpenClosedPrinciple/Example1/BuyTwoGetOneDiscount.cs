using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Example1
{
    class BuyTwoGetOneDiscount : IDiscount
    {
        public decimal CalculateDiscount(decimal singleItemPrice, int quantity)
        {
            return singleItemPrice * (quantity / 2);
        }
    }
}
