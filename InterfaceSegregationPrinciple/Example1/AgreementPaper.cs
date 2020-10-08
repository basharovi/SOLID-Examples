using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Example1
{
    class AgreementPaper : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
