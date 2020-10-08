namespace DependencyInversionPrinciple.Example2
{
    class MultiplicationCalculator : ICalculator
    {
        public int Calculate(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
    }
}
