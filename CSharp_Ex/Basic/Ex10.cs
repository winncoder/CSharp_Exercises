using System;

namespace CSharp_Ex
{
    public class Ex10
    {
        public static void Ex10_main()
        {
            //4 8 12 16 20 24 28
            //6 12 18 24 30
            int a, b;
            Console.WriteLine("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = int.Parse(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Khong co uoc chung va boi chung");
            }
            else if (a == 0 || b == 0)
            {
                Console.WriteLine("Khong co boi chung");
                // if (a == 0)
                // {
                //    Console.WriteLine($"Uoc chung lon nhat la: {b}");
                // }
                // else
                // {
                //     Console.WriteLine($"Uoc chung lon nhat la: {a}");
                // }
                Console.WriteLine(a == 0 ? $"Uoc chung lon nhat la: {b}" : $"Uoc chung lon nhat la: {a}");
            }
            else
            {
                int ucln = 1;
                for (int i = 1; i <= a && i <= b; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        ucln = i;
                    }
                }
                Console.WriteLine("Uoc chung lon nhat: " + ucln);
                Console.WriteLine("Boi chung nho nhat: " + a * b / ucln);
            }
        }
    }
}