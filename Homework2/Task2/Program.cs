using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number: ");
            string input = Console.ReadLine();
            int num;
            bool result = Int32.TryParse(input, out num);
            int a = 1;
          

            for (int i = 1; i <= num; i++)
            {
                for (int k = num - 1; k >= i; k--)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++, a++)
                {

                    Console.Write(a + " ");

                }

                Console.WriteLine();

            }
            Console.Read();
        }
    }
}
