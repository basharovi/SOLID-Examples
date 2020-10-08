using System;
using LiskovSubstitutionPrinciple.Example1;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPhone = new SmartPhone
            {
                MfgDate = DateTime.Today,
                Color = "Black",
                FourGInternet = true
            };

            Console.WriteLine($"Mfg Date = {myPhone.MfgDate} , Color = {myPhone.Color}, Is 4G Supported = {myPhone.FourGInternet}");
        }
    }
}
