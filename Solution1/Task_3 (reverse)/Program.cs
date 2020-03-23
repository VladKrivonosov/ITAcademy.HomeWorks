using System;
using System.Diagnostics;

namespace Task_3__reverse_
{
    class Program
    {
        static void Main(string[] args)
        {
            var mircReverse = new Stopwatch();

            long[] randomArray = new long[100000000];
            Random randomNumber = new Random();
            for (int j = 0; j < randomArray.Length; j++)
            {
                randomArray[j] = randomNumber.Next(0, 100);
            }

            mircReverse.Start();
            Array.Reverse(randomArray);
            mircReverse.Stop();

            Console.WriteLine($"Time microsoft reverse: {mircReverse.ElapsedMilliseconds}");

            var myReverse = new Stopwatch();

            
            long arrayLenght = randomArray.Length;
            long halfArray = arrayLenght / 2;
            long numb;

            myReverse.Start();

            for (long i = 0; i < halfArray; i++)
            {
                numb = randomArray[i];
                randomArray[i] = randomArray[arrayLenght - i - 1];
                randomArray[arrayLenght - i - 1] = numb;
            }

            myReverse.Stop();

            Console.WriteLine($"Time my reverse: {myReverse.ElapsedMilliseconds}");
        }
            
    }
}
