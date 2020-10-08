using OpenClosedPrinciple.Example1;
using OpenClosedPrinciple.Example2;
using System;
using OpenClosedPrinciple.Example3;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();
            IDiscount discount = new BuyThreeGetOneDiscount();

            var discountAmount = discount.CalculateDiscount(25, 4);
            printer.Print(discountAmount);


            ILogin login = new LoginWithMobileNoAndPassword(017, "1234");
            printer.Print(login.IsUserValid());
        }
    }
}
