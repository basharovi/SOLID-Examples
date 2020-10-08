using SingleResponsibilityPrinciple.Example1;
using SingleResponsibilityPrinciple.Example2;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new ConsolePrinter();

            var calculator = new BillCalculator(new BuyTwoGetOneDiscount());
            var myPayableAmount = calculator.CalculatePayableBill(11);
            printer.Print(myPayableAmount);


            var service = new UserService();
            var isAdded = service.AddUser(
                new UserViewModel
                {
                    Name = "Bashar Ovi",
                    Age = 22
                });
            printer.Print(isAdded);
        }
    }
}
