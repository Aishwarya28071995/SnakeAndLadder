using System;

namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake and Ladder game played with single player at start position 0");
            int position = 0;
            Random random = new Random();
            int number = random.Next(0, 7);
            Console.WriteLine(number);
        }
    }
}
