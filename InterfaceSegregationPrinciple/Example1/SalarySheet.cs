using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Example1
{
    public class SalarySheet : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
