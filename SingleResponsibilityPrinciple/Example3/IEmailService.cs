namespace SingleResponsibilityPrinciple.Example3
{
    public interface IEmailService
    {
        void SendEmail(string receiverEmail, object attachment);
    }
}
