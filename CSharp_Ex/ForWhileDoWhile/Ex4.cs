using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex4
    {
        public static void Ex4_main()
        {
            int h, index;
            
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            index = h;
            for (int i = 1; i <= h; i++) //chieu cao
            {
                for (int j = index-1; j >= 1; j--) //in khoang cach
                {
                    Console.Write(" ");
                }
                index--;
                for (int j = 1; j <= i; j++) //in sao
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}