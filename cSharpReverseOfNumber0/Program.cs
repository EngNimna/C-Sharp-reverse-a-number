using System;

namespace cSharpReverseOfNumber0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, num2, rem = 0, rev = 0;
            Console.Write("Enter the number...: ");
            num = int.Parse(Console.ReadLine());
            num2 = num;

            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
            Console.WriteLine("The number you entered = " + num2 + "                       The reverse of that number is = " + rev);
        }
    }
}
