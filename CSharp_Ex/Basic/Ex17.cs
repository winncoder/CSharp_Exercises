using System;

namespace CSharp_Ex.Basic
{
    public class Ex17
    {
        public static void Ex17_main()
        {
            Console.WriteLine("Enter Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);


            DateTime dayAfter1000 = date.AddDays(1000);
            string day1000 = dayAfter1000.ToString("dddd");
            Console.WriteLine("Day after 1000 days: "+ day1000 + "(" + dayAfter1000.ToString("yy-MM-dd") + ")");
            
            DateTime yearAfter100 = date.AddYears(100);
            string year1000 = yearAfter100.ToString("dddd");
            Console.WriteLine("Day after 100 years: "+ year1000 + "(" + yearAfter100.ToString("yy-MM-dd") + ")");
        }
    }
}