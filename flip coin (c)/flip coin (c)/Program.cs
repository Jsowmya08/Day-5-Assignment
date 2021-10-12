using System;

namespace flip_coin__c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int tails = 0;
            int heads = 0;
            int percent = 10;

            Random rnd = new Random();
            int count = rnd.Next(0, 1);

            for (int i = 10; i <= 10; i++) 
            {
                if (count <= 10)
                {
                    Console.WriteLine(heads);
                    percent = (heads / 10) * 100;
                        Console.WriteLine(percent);
                }
                else
                {
                    Console.WriteLine(tails);
                    percent = (tails  / 10) * 100;
                    Console.WriteLine(percent);
                }
            }
        }
    }
}
