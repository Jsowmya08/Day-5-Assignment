using System;

namespace flip_coin_b_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int tails = 0;
            int heads = 0;

            Random rnd = new Random();
            int value = rnd.Next(0, 1);

            if (count <= 0.5) 
            {
                Console.WriteLine("is tails");
            }
            else
            {
                Console.WriteLine("is heads");
            }
        }
    }
}
