using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array length: ");
            string input = Console.ReadLine();
            int length;
            bool result = Int32.TryParse(input, out length);

            while (!result)
            {
                Console.WriteLine(input + " is not a number!");
                Console.WriteLine("Enter array length: ");
                input = Console.ReadLine();
                result = Int32.TryParse(input, out length);
            }

            Console.WriteLine("Array length: " + length);

            int[] array = new int[length];
            string value; 
            int x;
            bool isValid;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter array element " + i);
                value = Console.ReadLine();
                isValid = Int32.TryParse(value, out x);

                while (!isValid)
                {
                    Console.WriteLine(value + " is not a number!");
                    Console.WriteLine("Enter array element " + i);
                    value = Console.ReadLine();
                    isValid = Int32.TryParse(value, out x);
                }

                array[i] = x;
            }

            Array.Sort(array);
            Console.WriteLine("Your array in Ascending order:");
            Console.WriteLine("[{0}]", string.Join(", ", array));

            Array.Reverse(array);
            Console.WriteLine("Your array in Descending order:");
            Console.WriteLine("[{0}]", string.Join(", ", array));

            Console.Read();

        }
    }
}
