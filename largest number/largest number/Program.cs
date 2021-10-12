using System;

namespace largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            
            num1 = 30;
            num2 = 20;
            num3 = 10;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        }
    }
}
