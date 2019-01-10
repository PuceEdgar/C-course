using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers: ");
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            string input3 = Console.ReadLine();

            int num1, num2, num3;
            bool result1 = Int32.TryParse(input1, out num1);
            bool result2 = Int32.TryParse(input2, out num2);
            bool result3 = Int32.TryParse(input3, out num3);

            while (!result1 || !result2 || !result3)
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
            }


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("Highest number: " + num1);
            } else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("Highest number: " + num2);
            } else
            {
                Console.WriteLine("Highest number: " + num3);
            }

            Console.Read();
        }

       
    }
}
