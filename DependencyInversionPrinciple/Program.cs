using DependencyInversionPrinciple.Example1;
using DependencyInversionPrinciple.Example2;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogin login = new LoginWithUserNameAndPassword("ABCD", "1234");

            Console.WriteLine(login.IsUserValid());

            var calculator = new Calculator(new MultiplicationCalculator());
            var result = calculator.Calculate(10, 20);

            Console.WriteLine(result);
        }
    }
}
