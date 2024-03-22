using System;
namespace RanDice
{
        class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(args[0]);
            int seed = int.Parse(args[1]);

            Random rand = new Random(seed);

            int resultado = 0;

            for (int d = 1; d <= count; d++)
            {
                total += rand.Next(1,7);
            }

            Console.WriteLine(resultado);
        }
    }
}