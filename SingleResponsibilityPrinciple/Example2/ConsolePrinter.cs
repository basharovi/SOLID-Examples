using System;

namespace SingleResponsibilityPrinciple.Example2
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(object anything)
        {
            Console.WriteLine(anything);
        }
    }
}
