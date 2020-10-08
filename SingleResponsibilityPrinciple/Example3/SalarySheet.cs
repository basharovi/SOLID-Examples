using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class SalarySheet : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
