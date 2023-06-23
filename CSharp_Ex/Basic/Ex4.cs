using System;

namespace CSharp_Ex.Properties
{
    public class Ex4
    {
        //Nhập một số nguyên và in ra màn hình số đó là số chẵn hay lẻ
        public static void Ex4_main()
        {
            Console.WriteLine("Enter the number: ");
            int num = int.Parse(Console.ReadLine());

            // if (num%2 > 0)
            // {
            //     Console.WriteLine(num + " La so Le");
            // }
            // else
            // {
            //     Console.WriteLine(num + " La so chan");
            // }
            
            if (num % 2 == 0)
            {
                Console.WriteLine($"So ban nhap la so chan {num}");
            }
            else
            {
                Console.WriteLine("So ban nhap la so le ");
            }
        }
    }
}