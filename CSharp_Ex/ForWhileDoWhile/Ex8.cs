using System;

namespace CSharp_Ex.ForWhileDoWhile
{
    public class Ex8
    {
        public static void Ex8_main()
        {
            int num, sum = 0;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                   Console.Write(i + " "); 
                   sum += i;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(sum);
            if (num == sum)
            {
                Console.WriteLine($"{num} La so hoan hao");
            }
            else
            {
                Console.WriteLine($"{num} La so khong hoan hao");
            }
        }
    }
}