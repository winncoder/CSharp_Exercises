using System;

namespace CSharp_Ex.Basic
{
    public class Ex19
    {
        public static void Ex19_main()
        {
            string str;
            Console.WriteLine("Input string: ");
            str = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                index++;
            }
            Console.WriteLine($"Do dai cua chuoi la: {index}");
        }
    }
}