using Newtonsoft.Json;

namespace CamelCaseConventions
{
    public class Calculator
    {
        public int AddNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int SubtractNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int MultiplyNumbers(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double DivideNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("Divisor cannot be zero.");
            return (double)dividend / divisor;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            //Console.WriteLine(JsonConverter.ReferenceEquals());
        }
    }
}
