using OpenClosedPrinciple.Example1;
using OpenClosedPrinciple.Example2;
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


            ILogin login = new LoginWithMobileNoAndPassword(017, "1234");

            Console.WriteLine(login.IsUserValid());
        }
    }
}
