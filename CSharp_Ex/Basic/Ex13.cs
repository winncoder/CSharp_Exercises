using System;
using System.Linq;

namespace CSharp_Ex.Basic
{
    public class Ex13
    {
        public static void Ex13_main()
        {
            int[] arr = { 5,7,2,4,6 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\nLength: " + arr.Length);
            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Min: " + arr.Min());
            Console.WriteLine("Sum: " + arr.Sum());
        }
    }
}