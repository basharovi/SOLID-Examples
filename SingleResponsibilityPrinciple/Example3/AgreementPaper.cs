using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class AgreementPaper : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
