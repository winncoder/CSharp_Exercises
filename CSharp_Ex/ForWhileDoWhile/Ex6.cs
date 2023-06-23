using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex6
    {
        public static void Ex6_main()
        {
            int h;
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++) //chieu cao
            {
                for (int j = 1; j <= h-i; j++) //in khoang cach
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2*i-1; j++) //in sao
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}