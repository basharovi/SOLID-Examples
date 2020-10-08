using System;

namespace LiskovSubstitutionPrinciple.Example1
{
    public class MobilePhone : Phone
    {
        public object Display { get; set; }
        public object Speaker { get; set; }
        public DateTime Clock { get; set; }
        public int NumberOfButton { get; set; }
    }
}
