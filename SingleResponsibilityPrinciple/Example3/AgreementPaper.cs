using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class AgreementPaper : IReport
    {
        public object GenerateReport(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
