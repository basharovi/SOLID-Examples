using System;

namespace LiskovSubstitutionPrinciple.Example1
{
    public class Battery : BaseModel
    {
        public object Type { get; set; }
        public decimal Voltage { get; set; }
    }
}
