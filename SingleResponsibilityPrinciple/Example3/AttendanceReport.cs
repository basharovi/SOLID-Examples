using System;

namespace SingleResponsibilityPrinciple.Example3
{
    public class AttendanceReport : IReport
    {
        public object GenerateReport(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
