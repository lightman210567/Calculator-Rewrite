using System;

namespace Calculator_rewrite
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please select one of the following operations\nAddition\nSubtraction\nMultiplication\nDivision");
            string operation = Console.ReadLine().ToLower();

            switch (operation)
            {
                case "addition":
                    break;
            }
        }
    }
}