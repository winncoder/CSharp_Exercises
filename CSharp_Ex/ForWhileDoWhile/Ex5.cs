using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex5
    {
        public static void Ex5_main()
        {
            int h, index =1 , k;
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            k = h;
            for (int i = 1; i <= h; i++) 
            {
                for (int j = k-1; j >= 1; j--) //in khoang cach
                {
                    Console.Write(" ");
                }
                k--;
                for (int j = 1; j <= i; j++) 
                {
                    Console.Write(index + " ");
                    index++;
                }
                Console.WriteLine();
            }
        }
    }
}