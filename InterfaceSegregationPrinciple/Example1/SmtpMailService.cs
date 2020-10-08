using System;

namespace InterfaceSegregationPrinciple.Example1
{
    public class SmtpMailService : IEmailService
    {
        public void SendEmail(string receiverEmail, object attachment)
        {
            throw new NotImplementedException();
        }
    }
}
