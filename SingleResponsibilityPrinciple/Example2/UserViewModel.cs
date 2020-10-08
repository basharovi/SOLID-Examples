
using System;

namespace SingleResponsibilityPrinciple.Example2
{
    public class UserViewModel
    {
        public Guid Id { get; set; } 

        public string Name { get; set; }

        public int Age { get; set; }

        public byte[] Photo { get; set; }
    }
}
