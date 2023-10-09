using System;
using System.Linq;

namespace CSharp_Ex.Basic
{
    public class SplitArray
    {
        public static void SplitArray_main()
        {
            /*// CÁCH 1:
            Console.Write("Enter array number: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }
            
            // Khởi tạo mảng số chẵn và mảng số lẻ
            int[] evenArray = new int[n];
            int[] oddArray = new int[n];

            int evenCount = 0; // Số lượng phần tử trong mảng số chẵn
            int oddCount = 0;  // Số lượng phần tử trong mảng số lẻ
            
            foreach (int num in originalArray)
            {
                if (num % 2 == 0)
                {
                    evenArray[evenCount] = num;
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = num;
                    oddCount++;
                }
            }
            
            Console.Write("Even Array: ");
            for (int i = 0; i < evenCount; i++)
            {
                Console.Write(evenArray[i] + " ");
            }
            
            Console.WriteLine();
            Console.Write("Odd Array: ");
            for (int i = 0; i < oddCount; i++)
            {
                Console.Write(oddArray[i] + " ");
            }*/
            
            //----------------------------------------
            // CÁCH 2:
            Console.Write("Enter array number: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            // Chia mảng thành hai mảng số chẵn và số lẻ
            int[] evenArray = originalArray.Where(x => x % 2 == 0).ToArray();
            int[] oddArray = originalArray.Where(x => x % 2 != 0).ToArray();

            // In ra mảng số chẵn
            Console.WriteLine("Even Array: ");
            foreach (int num in evenArray)
            {
                Console.WriteLine(num);
            }

            // In ra mảng số lẻ
            Console.WriteLine("Odd Array: ");
            foreach (int num in oddArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}