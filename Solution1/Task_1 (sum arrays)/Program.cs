using System;

namespace Task_1__sum_arrays_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array lenght : ");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int[] mass_key = new int[lenght];
            int i = 0;
            while (i < lenght)
            {
                Console.WriteLine("Enter numbers");
                mass_key[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }

            Console.Clear();

            Console.WriteLine("Array from numpad");
            for (i = 0; i < lenght; i++)
            {
                Console.Write(mass_key[i] + " ");
            }

            int[] _random = new int[lenght];
            Random random_numbers = new Random();
            for (int j = 0; j < _random.Length; j++)
            {
                _random[j] = random_numbers.Next(0, 50);
            }

            Console.WriteLine("\n\nRandom array");
            for (int j = 0; j < _random.Length; j++)
            {
                Console.Write(_random[j] + " ");
            }

            int[] summ_array = new int[lenght];
            for (int k = 0; k < summ_array.Length; k++)
            {
                summ_array[k] = mass_key[k] + _random[k];
            }

            Console.WriteLine("\n\nSum array");
            for (int k = 0; k < summ_array.Length; k++)
            {
                Console.Write(summ_array[k] + " ");
            }
        }
    }
}
