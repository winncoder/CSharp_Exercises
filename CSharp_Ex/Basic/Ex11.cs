using System;

namespace CSharp_Ex
{
    public class Ex11
    {
        public static void Ex11_main()
        {
            int num;
            int a = 2;
            Console.WriteLine("Enter number: ");
            num = int.Parse(Console.ReadLine());

            while (a < num) 
            {
                bool nguyenTo = true;
                if (num < 2)
                {
                    nguyenTo = false;
                }
                
                else
                {
                    int i = 2;
                    while (i <= Math.Sqrt(a))
                    {
                        if (a % i == 0)
                        {
                            nguyenTo = false;
                            break;
                        }
                        i++;
                    }
                }
                
                if (nguyenTo)
                {
                    Console.Write($"{a} ");
                }
                
                a++;
            }
        }
    }
}
// for (int i = 1; i <= a; i++)
// {
//     if (a % i == 0)
//     {
//         index++;
//     }
// }
//
// if (index == 2)
// {
//     
// }