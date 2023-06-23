using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex9
    {
        //Nhập vào hai số a,b
        //rồi in ra màn hình những số nguyên tố nằm trong khoảng a - b đó
        public static void Ex9_main()
        {
            int a, b;//a= 2 , b= 5
            Console.WriteLine("Enter number a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++) //xac dinh nhung so trong khoang a-b
            {
                int index = 0;
                for (int j = 1; j <= i; j++) //xac dinh nhung so nguyen to trong khoang do
                {
                    if (i % j == 0)
                    {
                        index++;
                    }
                }

                if (index == 2)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}