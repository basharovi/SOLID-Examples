using System;

namespace LiskovSubstitutionPrinciple.Example1
{
    public abstract class Phone : BaseModel
    {
        public Battery Battery { get; set; }
    }
}
