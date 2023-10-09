using System;

namespace CSharp_Ex.Basic
{
    public class SumElements
    {
        public static void SumElements_main()
        {
            int SumE = 0;
            Console.Write("Enter array number: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
                SumE = SumE + originalArray[i];
            }
            
            Console.WriteLine($"Sum Elements: {SumE}");
        }
    }
}