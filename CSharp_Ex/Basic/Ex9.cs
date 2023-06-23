using System;

namespace CSharp_Ex
{
    public class Ex9
    {
        public static void Ex9_main()
        {
            float a, b , c;
            Console.WriteLine("Enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c:");
            c = Convert.ToInt32(Console.ReadLine());

            float delta = (b * b) - 4 * a * c;
            if (a == 0 && b == 0 && c!= 0)
            {
                Console.WriteLine("Error");
                
            }
            else if (a == 0 && b == 0 && c == 0)
            {
                Console.WriteLine("Phuong trinh vo so nghiem");
            }
            else if (a == 0 && b != 0 && c != 0)
            {
                Console.WriteLine("Phuong trinh co 1 nghiem: x = " + Math.Round(-c/b, 2)); //bx + c = 0 -> x = -c/b
            }
            else
            {
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta > 0)
                {
                    Console.WriteLine("Phuong trinh ton tai 2 nghiem phan biet: ");
                    Console.WriteLine("x1: " + (-b-Math.Sqrt(delta)/2*a));
                    Console.WriteLine("x2: " + (-b+Math.Sqrt(delta)/2*a));
                }
                else //xet delta = 0
                {
                    Console.WriteLine("Phuong trinh co nghiem kep: " + Math.Round(-b/2*a));
                }
            }
        }
        
    }
}