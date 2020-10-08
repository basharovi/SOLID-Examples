using InterfaceSegregationPrinciple.Example1;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = new UserService();
            
            var anUser = new User
            {
                Name = "Mr. ABC",
                Email = "abc@abc.com"
            };

            userService.AddUser(anUser);

            IReport report = new AgreementPaper();
            var aReport = report.GenerateReport(anUser);

            IEmailService emailService = new SmtpMailService();
            emailService.SendEmail(anUser.Email, aReport);
        }
    }
}
