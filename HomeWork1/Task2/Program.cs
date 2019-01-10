using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Enter 2 numbers:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1, num2;
            bool result1 = Int32.TryParse(input1, out num1);
            bool result2 = Int32.TryParse(input2, out num2);

            while (!result1 || !result2)
            {
                while (!result1)
                {
                    Console.WriteLine(input1 + " not a number. Try again: ");
                    input1 = Console.ReadLine();
                    result1 = Int32.TryParse(input1, out num1);
                }
                while (!result2)
                {
                    Console.WriteLine(input2 + " not a number. Try again: ");
                    input2 = Console.ReadLine();
                    result2 = Int32.TryParse(input2, out num2);
                }
            }

            Console.WriteLine("Entered numbers: " + num1 + " " + num2);
            int num3 = num1;
            num1 = num2;
            num2 = num3;

            Console.WriteLine("After exchange: " + num1 + " " + num2);

            Console.Read();
        }
    }
}
