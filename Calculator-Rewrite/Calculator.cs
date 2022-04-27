using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_rewrite
{
    internal class Calculator
    {
        public static int Addition(int firstNumber, int secondNumber)
        {
            int additionResult = firstNumber + secondNumber;

            return additionResult;
        }

        public static int Subtraction(int firstNumber, int secondNumber)
        {
            int subtractionResult = firstNumber - secondNumber;

            return subtractionResult;
        }

        public static int Multiplication(int firstNumber, int secondNumber)
        {
            int multiplicationResult = firstNumber * secondNumber;

            return multiplicationResult;
        }
    }
}
