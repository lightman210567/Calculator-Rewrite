using System;

namespace Calculator_rewrite
{
    class Program
    {
        public static void Main(string[] args)
        {
            int firstnumber;
            int secondNumber;

            string userInput;

            Console.WriteLine("Please enter the first number");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out firstnumber);

            Console.WriteLine("Please enter the second number");
            userInput = Console.ReadLine();
            int.TryParse(userInput, out secondNumber);

            Console.WriteLine("Please select one of the following operations\nAddition");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "addition":
                    int additionResult = Calculator.Addition(firstnumber, secondNumber);
                    Console.WriteLine($"{firstnumber} + {secondNumber} = {additionResult}");
                    break;
            }
        }
    }
}