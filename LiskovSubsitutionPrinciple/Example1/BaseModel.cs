using System;

namespace LiskovSubstitutionPrinciple.Example1
{
    public abstract class BaseModel
    {
        public string Model { get; set; }
        public DateTime MfgDate { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
    }
}
