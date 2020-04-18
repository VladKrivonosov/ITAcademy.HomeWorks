using System;

namespace Task_2__move_array_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght : ");
            int elements = int.Parse(Console.ReadLine());
            int[] sourceArray = new int[elements];
            for (int i = 0; i < sourceArray.Length-1; i++)
            {
                Console.Write($"Enter numer index {i} : ");
                sourceArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Clear();

            Console.WriteLine("\nArray from numpad");
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.Write(sourceArray[i] + " ");
            }

            Console.WriteLine("\n\nEnter number to add array :");
            string key = Console.ReadLine();
            int.TryParse(key, out sourceArray[sourceArray.Length-1]);

            Console.WriteLine("\nEnter the number position in array : ");
            int position = Convert.ToInt32(Console.ReadLine());

            for (int j = sourceArray.Length - 1; j != position; j--)
            {
                int numb = sourceArray[j];
                sourceArray[j] = sourceArray[j - 1];
                sourceArray[j - 1] = numb;
            }

            Console.WriteLine("\nNew array");
            for (int i = 0; i < sourceArray.Length; i++)
            {
                Console.Write(sourceArray[i] + " ");
            }
        }
    }
}
