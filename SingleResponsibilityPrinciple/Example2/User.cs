using System;

namespace SingleResponsibilityPrinciple.Example2
{
    public class User
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public int Age { get; set; }

        public string PhotoPath { get; set; }

    }
}
