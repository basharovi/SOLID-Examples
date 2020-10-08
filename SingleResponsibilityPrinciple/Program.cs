using SingleResponsibilityPrinciple.Example1;
using SingleResponsibilityPrinciple.Example2;
using SingleResponsibilityPrinciple.Example3;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();

            // For Example 1
            var calculator = new BillCalculator(new BuyTwoGetOneDiscount());
            var myPayableAmount = calculator.CalculatePayableBill(11);
            printer.Print(myPayableAmount);

            // For Example 2
            var service = new UserService();
            var isAdded = service.AddUser(
                new UserViewModel
                {
                    Name = "Bashar Ovi",
                    Age = 22
                });
            printer.Print(isAdded);


            // For Example 3
            IEmployeeService employeeService = new EmployeeService();

            var anEmployee = new Employee
            {
                Name = "Mr. ABC",
                Email = "abc@abc.com"
            };

            employeeService.Update(anEmployee);

            IReport report = new SalarySheet();
            var aReport = report.GenerateReport(anEmployee);

            IEmailService emailService = new SmtpMailService();
            emailService.SendEmail(anEmployee.Email, aReport);
        }
    }
}
