using System;
using System.Text;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");

            Console.WriteLine($"Исхлдная строка: {str}");

            int i = 0;
            while (str[i] != '?')
            {
                if (str[i] == '!' || str[i] == '.')
                {
                    str.Remove(i, 1);
                    --i;
                }
                i++;
            }

            int numberID = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j]=='?')
                {
                    numberID = i;
                    break;
                }
            }

            for (int k = numberID; k < str.Length; k++)
            {
                if (char.IsWhiteSpace(str[k]))
                {
                    str.Replace(str[k], '_',k,1);
                }
            }
            Console.WriteLine($"Форматированная строка: {str}");
        }
    }
}
