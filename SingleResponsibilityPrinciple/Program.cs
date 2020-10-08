using SingleResponsibilityPrinciple.Example1;
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new BillCalculator(new BuyThreeGetOneDiscount());

            var myPaybleAmout = calculator.CalculatePaybleBill(10);

            Console.WriteLine(myPaybleAmout);
        }
    }
}
