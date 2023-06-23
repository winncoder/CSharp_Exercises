using System;

namespace CSharp_Ex
{
    public class Ex1
    {
        //Nhập số từ 1 đến 7  rồi in ra màn hình ngày trong tuần tương đương,
        //nếu nhập số khác thì in ra màn hình “Invalid day”
        public static void Ex1_main()
        {
            Console.WriteLine("What day is today?");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }
    }
}