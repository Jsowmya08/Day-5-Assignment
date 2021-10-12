using System;

namespace head_or_tails
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int tails = 0;
            int heads = 0;
            int percentage = 0;

            while (count < 10)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails!");
                    tails = tails + 1;
                    count = count + 1;

                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    heads = heads + 1;
                    count = count + 1;
                }
            }
            Console.WriteLine("Heads = " + heads + "Tails = " + tails + " Counts = " + count);
            Console.ReadLine();
        }
    }
}
