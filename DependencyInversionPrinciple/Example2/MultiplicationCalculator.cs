namespace DependencyInversionPrinciple.Example2
{
    public class MultiplicationCalculator : ICalculator
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
