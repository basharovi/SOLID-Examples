using DependencyInversionPrinciple.Example1;
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ILogin login = new LoginWithUserNameAndPassword("ABCD", "1234");

            Console.WriteLine(login.IsUserValid());
        }
    }
}
