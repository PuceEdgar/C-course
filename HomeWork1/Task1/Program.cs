using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            int num;
            bool result = Int32.TryParse(input, out num);

            while (!result)
            {
                Console.WriteLine(input + " not a number. Try again: ");
                input = Console.ReadLine();
                result = Int32.TryParse(input, out num);
            }

            Console.WriteLine("Hi " + name + " " + surname);
            Console.WriteLine("Your number: " + num);
            Console.Read();
        }
    }
}
