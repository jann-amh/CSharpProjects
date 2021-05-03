namespace Calculator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Calculator calculator = new Calculator(23, 4);
            calculator.Add();
            calculator.Sub();
            calculator.Multi();
            calculator.Divide();
        }
    }
}
