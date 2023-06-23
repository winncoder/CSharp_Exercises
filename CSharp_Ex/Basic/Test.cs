using System;

namespace CSharp_Ex.Basic
{
    public class Test
    {
        public static void test_main()
        {
            Console.WriteLine("Enter: ");
            string a = Console.ReadLine();
            int b = a.IndexOf("e");
            Console.WriteLine(b);
        }
    }
}