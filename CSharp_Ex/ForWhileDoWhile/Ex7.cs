using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex7
    {
        public static void Ex7_main()
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
            for (int i = h-1; i >= 1; i--)
            {
                for (int j = i; j <= h-1; j++) //in khoang cach
                {
                    Console.Write(" ");
                }
                for (int j = 2*i-1; j >= 1; j--) //in sao
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}