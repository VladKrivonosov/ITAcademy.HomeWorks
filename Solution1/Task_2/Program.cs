using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press W/A/S/D to move: ");
            string key = Console.ReadLine();
            switch (key)
            {
                case "w":
                    Console.WriteLine("You move UP");
                    break;
                case "a":
                    Console.WriteLine("You move LEFT");
                    break;
                case "s":
                    Console.WriteLine("You move DOWN");
                    break;
                case "d":
                    Console.WriteLine("You move RIGHT");
                    break;
                default:
                    Console.WriteLine("You dont move");
                    break;
            }
        }
    }
}
