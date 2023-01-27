using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] rel = Array.ConvertAll(input, int.Parse);

            if (rel[1] >= rel[2])
            {
                Console.WriteLine("-1");
            }
            else
            {
                int eventPoint = rel[0] / (rel[2] - rel[1]) + 1;
                Console.WriteLine(eventPoint);
            }
        }
    }
}
