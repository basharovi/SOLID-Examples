using SingleResponsibilityPrinciple.Example1;
using System;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new BillCalculator(new BuyTwoGetOneDiscount());

            var myPayableAmount = calculator.CalculatePayableBill(11);

            Console.WriteLine(myPayableAmount);
        }
    }
}
