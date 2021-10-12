using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to reverse : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (Number > 0)
            {
                int remainder = Number % 10;
                reverse = (reverse * 10) + remainder;
                Number = Number / 10;
            }
            Console.WriteLine(" reverse number is  {0}", reverse);
            Console.ReadLine();
        }
    }
}
    
