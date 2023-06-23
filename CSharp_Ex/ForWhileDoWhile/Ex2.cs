using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex2
    {
        //vẽ tam giác vuông theo chiều cao (nhưng các hàng được cấu thành từ các số giống nhau)
        //vd h=3
        //1
        //22
        //333


        
        public static void Ex2_main()
        {
            int h;
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}