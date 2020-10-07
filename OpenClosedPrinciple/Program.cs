using OpenClosedPrinciple.Example1;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IDiscount discount = new BuyThreeGetOneDiscount();

            var discountAmount = discount.CalculateDiscount(25, 4);

            Console.WriteLine(discountAmount);
        }
    }
}
