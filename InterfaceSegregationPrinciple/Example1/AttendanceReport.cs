using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Example1
{
    public class AttendanceReport : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
