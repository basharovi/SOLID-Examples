using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class AttendanceReport : IReport
    {
        public object GenerateReport(User user)
        {
            throw new NotImplementedException();
        }
    }
}
