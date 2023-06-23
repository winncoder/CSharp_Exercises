using System;

namespace CSharp_Ex
{
    public class Ex7
    {
        
        public static void Ex7_main()
        {
            int a, b, index;
            Console.WriteLine("Enter a: ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("nhap phep tinh(1:/,2:*,3:+,4:-,5:%): ");
                index = Int32.Parse(Console.ReadLine());
                switch (index)
                {
                    case 1:
                        Console.Write("Enter b:");
                        b = Int32.Parse(Console.ReadLine());
                        double thuong = (double)a / b;
                        thuong = Math.Round(thuong, 2);
                        Console.WriteLine($"{a} chia {b} = {thuong}");
                        break;
                    case 2:
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write($"phep nhan cua {a} va {b} la {a*b}");
                        break;
                    case 3:
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write($"phep cong cua {a} va {b} la {a+b}");
                        break;
                    case 4:
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write($"phep tru cua {a} va {b} la {a-b}");
                        break;
                    case 5:
                        Console.Write("Nhap b: ");
                        b = int.Parse(Console.ReadLine());
                        Console.Write($"phep chia lay du cua {a} va {b} la {a%b}");
                        break;
                    default:
                        Console.WriteLine("Bye Bye");
                        break;
                }


        }
    }
}