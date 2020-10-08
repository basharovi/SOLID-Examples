using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class SalarySheet : IReport
    {
        public object GenerateReport(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
