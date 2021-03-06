using System;

namespace Calculator_rewrite
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            string userInput;

            Console.WriteLine("Please enter the first number");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out firstNumber);

            Console.WriteLine("Please enter the second number");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out secondNumber);

            Console.WriteLine("Please select one of the following operations\nAddition\nSubtraction\nMultiplication\nDivision");
            string operation = Console.ReadLine().ToLower();
            Console.WriteLine("");

            switch (operation)
            {
                case "addition":
                    int additionResult = Calculator.Addition(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {additionResult}");
                    break;
                case "subtraction":
                    int subtractionResult = Calculator.Subtraction(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {subtractionResult}");
                    break;
                case "multiplication":
                    int multiplicationResult = Calculator.Multiplication(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} multiplied by {secondNumber} = {multiplicationResult}");
                    break;
                case "division":
                    int divisionResult = Calculator.Division(firstNumber, secondNumber);
                    Console.WriteLine($"{firstNumber} divided by {secondNumber} = {divisionResult}");
                    break;
            }

            Console.ReadLine();
        }
    }
}