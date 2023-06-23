using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    //vẽ tam giác vuông dạng số theo chiều cao
    public class Ex1
    {
        public static void Ex1_main()
        {
            int h;
            Console.WriteLine("Enter the height: ");
            h = int.Parse(Console.ReadLine());
            for (int i = 1; i <= h; i++) //duyet tung dong cua tam giac vuong
            {
                for (int j = 1; j <= i; j++) //in ra các số trên mỗi dòng
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}