namespace InterfaceSegregationPrinciple.Example1
{
    public interface IEmailService
    {
        void SendEmail(string receiverEmail, object attachment);
    }
}
