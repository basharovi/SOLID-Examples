namespace DependencyInversionPrinciple.Example2
{
    public class Calculator
    {
        private readonly ICalculator _calculator;

        public Calculator(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public int Calculate(int firstNumber, int secondNumber)
        {
            return _calculator.Calculate(firstNumber, secondNumber);
        }
    }
}
