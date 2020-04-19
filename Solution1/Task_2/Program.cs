using System;
using System.Linq;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String: ");
            string writeString = Console.ReadLine();
            task_01(writeString);
            task_02(writeString);
            task_03(writeString);
            task_04(writeString);
        }

        static void task_01(string writeString)
        {
            string[] stringArray = writeString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLen = 0;
            int MAXwordID = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxLen)
                {
                    maxLen = stringArray[i].Length;
                    MAXwordID = i;
                }
            }
            Console.WriteLine($"Longest word: {stringArray[MAXwordID]}");
        }

        static void task_02(string writeString)
        {
            string[] stringArray = writeString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int maxLenID = 0, minLenID = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[maxLenID].Length < stringArray[i].Length)
                {
                    maxLenID = i;
                }
                if (stringArray[minLenID].Length > stringArray[i].Length)
                {
                    minLenID = i;
                }
            }
            string wordMemory = stringArray[minLenID];
            stringArray[minLenID] = stringArray[maxLenID];
            stringArray[maxLenID] = wordMemory;
            Console.WriteLine($"Replace : {string.Join(" ", stringArray)}");
        }

        static void task_03(string writeString)
        {
            int punctMark = writeString.Count(char.IsPunctuation);
            int numbLetters = writeString.Split(' ').Length;
            Console.WriteLine($"Letters number : {writeString.Length - numbLetters - punctMark + 1}");
            Console.WriteLine($"Punctuation mark : {punctMark}");
        }

        static void task_04(string writeString)
        {
            string[] stringArray = writeString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string bufer = " ";
            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                for (int j = i + 1; j < stringArray.Length; j++)
                {
                    if (stringArray[i].Length > stringArray[j].Length)
                    {
                        bufer = stringArray[i];
                        stringArray[i] = stringArray[j];
                        stringArray[j] = bufer;
                    }
                }
            }
        }
    }
}

