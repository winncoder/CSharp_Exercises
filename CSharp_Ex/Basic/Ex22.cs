using System;

namespace CSharp_Ex.Basic
{
    public class Ex22
    {
        public static void Ex22_main()
        {
            Console.WriteLine("Enter the number of elements of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new String[n];

            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Console.ReadLine();
            }
            
            Console.WriteLine("Array of numbers before sorting: ");
            PrintArray(arr);

            Array.Reverse(arr);
            Console.WriteLine("Array of numbers after sorting descending: ");
            PrintArray(arr);
        }
        
        static void PrintArray(string[] arr)
        {
            foreach (string str in arr)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();
        }
    }
}