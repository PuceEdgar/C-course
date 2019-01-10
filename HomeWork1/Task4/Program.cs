using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Enter 4 numbers:");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();
            string input4 = Console.ReadLine();

            int num1, num2, num3, num4;
            bool result1 = Int32.TryParse(input1, out num1);
            bool result2 = Int32.TryParse(input2, out num2);
            bool result3 = Int32.TryParse(input3, out num3);
            bool result4 = Int32.TryParse(input4, out num4);

            while (!result1 || !result2 || !result3 || !result4)
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

                while (!result3)
                {
                    Console.WriteLine(input3 + " not a number. Try again: ");
                    input3 = Console.ReadLine();
                    result3 = Int32.TryParse(input3, out num3);
                }
                while (!result4)
                {
                    Console.WriteLine(input4 + " not a number. Try again: ");
                    input4 = Console.ReadLine();
                    result4 = Int32.TryParse(input4, out num4);
                }
            }

            double sum = num1 + num2 + num3 + num4;
            string result = String.Format("{0:0.##}", sum / 4);
            Console.WriteLine("average is: " + result);
            Console.Read();
        }
    }
}
