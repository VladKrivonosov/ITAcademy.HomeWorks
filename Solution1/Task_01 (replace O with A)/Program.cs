using System;
using System.Diagnostics;

namespace Task_01__replace_O_with_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write vers:");
            string verseInLine = Console.ReadLine();
            string[] singleLines = verseInLine.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            Console.Clear();
            for (int i = 0; i < singleLines.Length; i++)
            {
                singleLines[i] = singleLines[i].Replace('О', 'А');
                singleLines[i] = singleLines[i].Replace('о', 'а');
                Console.WriteLine(singleLines[i]);
            }
        }
    }
}
