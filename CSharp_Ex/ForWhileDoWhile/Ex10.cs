using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex10
    {
        public static void Ex10_main()
        {
            int a, b;//a= 2 , b= 5
            Console.WriteLine("Enter number a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b: ");
            b = int.Parse(Console.ReadLine());
            
            for (int i = a; i <= b; i++) 
            {
                
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += j;
                    }
                
                }
                if (i == sum && sum != 0)
                {
                    Console.WriteLine(i + " ");
                }

            }
        }
    }
}