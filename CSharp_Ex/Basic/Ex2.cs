using System;

namespace CSharp_Ex.Properties
{
    public class Ex2
    {   
        //*Nhập một số bất kỳ rồi in ra tổng giá trị các chữ số của số đó(1234->1+2+3+4=10=sum)
        public static void Ex2_main()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int index = 0, sum = 0;
            while ( number > 0)
            {
                index = number%10;
                sum = sum + index;
                //sum += index;
                number = number / 10;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}