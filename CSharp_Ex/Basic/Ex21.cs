using System;

namespace CSharp_Ex.Basic
{
    public class Ex21
    {
        public static void Ex21_main()
        {
            int a, b, sum=0;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}