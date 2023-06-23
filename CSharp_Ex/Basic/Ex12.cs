using System;

namespace CSharp_Ex
{
    public class Ex12
    {
        public static void Ex12_main()
        {
            int num, index = 0;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    //index = index + 1;
                    //index += 1;
                    index++; //boi vi la so 1 nen duoc dung cach nay
                }
            }

            if (index == 2)
            {
                Console.WriteLine("La so nguyen to");
            }
            else
            {
                Console.WriteLine("Khong phai so nguyen to");
            }
            
            Console.WriteLine(index == 2 ? "La so nguyen to": "Khong phai la so nguyen to");
        }
    }
}