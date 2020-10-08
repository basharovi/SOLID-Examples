using System;

namespace InterfaceSegregationPrinciple.Example1
{
    public class SmtpMailService : IEmailService
    {
        public void SendEmail(string receiverEmail)
        {
            throw new NotImplementedException();
        }
    }
}
