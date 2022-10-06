
namespace ClassLibraryCalculator
{
    public class Calculator
    {
        public static double Add(double number1, double number2, params double[] numbers)
        {
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum + number1 + number2;
        }
        public static double Mult(double number1, double number2, params double[] numbers)
        {
            double mult = 1;
            foreach (double number in numbers)
            {
                mult *= number;
            }
            return mult * number1 * number2;
        }
    }
}
