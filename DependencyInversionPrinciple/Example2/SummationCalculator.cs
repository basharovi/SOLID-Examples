namespace DependencyInversionPrinciple.Example2
{
    public class SummationCalculator : ICalculator
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
