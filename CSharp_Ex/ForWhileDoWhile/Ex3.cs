using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex3
    {
        public static void Ex3_main()
        {
            int h, index = 1;
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++) 
            {
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