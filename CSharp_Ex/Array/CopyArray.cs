using System;

namespace CSharp_Ex.Basic
{
    public class CopyArray
    {
        public static void CopyArray_main()
        {
            // Nhập mảng số nguyên từ người dùng
            Console.Write("Enter Array number: ");
            int n = int.Parse(Console.ReadLine());

            int[] originalArray = new int[n];

            Console.WriteLine("Enter array element:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Element {i + 1}: ");
                originalArray[i] = int.Parse(Console.ReadLine());
            }

            // Khởi tạo mảng sao chép
            int[] exCopyArray = new int[n]; // Sử dụng tên 'exCopyArray'

            // Sử dụng Array.Copy để sao chép mảng ban đầu vào mảng sao chép
            Array.Copy(originalArray, exCopyArray, n);

            // In ra mảng số nguyên sao chép
            Console.Write("Mảng số nguyên sao chép:");
            foreach (int num in exCopyArray)
            {
                Console.WriteLine(num);
            }
        }
    }
}