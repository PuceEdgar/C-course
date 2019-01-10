using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Enter number:");
            string input1 = Console.ReadLine();

            int num1;
            bool result1 = Int32.TryParse(input1, out num1);

            while (!result1)
            {
                Console.WriteLine(input1 + " not a number. Try again: ");
                input1 = Console.ReadLine();
                result1 = Int32.TryParse(input1, out num1);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num1 + " * " + i + " = " + num1 * i);
            }

            Console.Read();
        }
    }
}
