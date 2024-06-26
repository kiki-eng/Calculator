using System;
using System.IO.Pipes;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {

                int num1;
                int num2;
                string answer;
                int result;

                Console.WriteLine("Welcome to my calculator");
                Console.WriteLine("Please enter your first number");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the second numbr");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("what type of operation do you want to perform");
                Console.WriteLine("Please enter a for addition, s for subtraction, m for multiplicatio and d for addition");
                answer = Console.ReadLine();

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }

                Console.WriteLine("The answer = " + result);
                Console.WriteLine("Do you want to perform another calculation (y/n)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
            Console.WriteLine("Goodbye");







        }
    }
}