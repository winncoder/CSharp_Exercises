using System;

namespace CSharp_Ex.Basic
{
    public class Ex20
    {
        public static void Ex20_main()
        {
            Console.WriteLine("Enter the number of elements of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements of the array: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array of numbers before sorting: ");
            PrintArray(arr);

            
            Array.Sort(arr);
            Console.WriteLine("Array of numbers after sorting ascending: ");
            PrintArray(arr);

            
            Array.Reverse(arr);
            Console.WriteLine("Array of numbers after sorting descending: ");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}