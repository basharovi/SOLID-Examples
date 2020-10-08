using System;

namespace OpenClosedPrinciple.Example3
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(object anything)
        {
            Console.WriteLine(anything);
        }
    }
}
