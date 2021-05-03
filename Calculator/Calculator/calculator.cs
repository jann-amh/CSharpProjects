using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public int Number1 { private get; set; }

        public int Number2 { private get; set; } 

        public Calculator(int number1, int number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        public void Add()
        {
            Console.WriteLine($"{Number1} + {Number2} = {Number1 + Number2}");
        }

        public void Sub()
        {
            Console.WriteLine($"{Number1} - {Number2} = {Number1 - Number2}");
        }

        public void Multi()
        {
            Console.WriteLine($"{Number1} * {Number2} = {Number1 * Number2}");
        }

        public void Divide()
        {
            Console.WriteLine($"{Number1} / {Number2} = {Number1 / Number2}");
        }
    }
}
