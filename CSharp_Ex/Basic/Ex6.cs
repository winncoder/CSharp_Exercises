using System;

namespace CSharp_Ex
{
    public class Ex6
    {
        //* Nhập vào số năm rồi in ra màn hình năm đó có phải nhuận hay không
        //Cách tính năm nhuận Dương lịch như sau: bạn lấy số năm đem chia cho 4,
        //nếu kết quả chia hết cho 4 thì năm nó là năm nhuận.
        //Với những năm tròn thế kỷ có 2 số 00 ở cuối thì lấy số năm chia cho 400,
        //nếu kết quả chia hết cho 400 thì năm đó là năm nhuận.
        public static void Ex6_main()
        {
            // Console.WriteLine("Enter the year: ");
            // int year = Convert.ToInt32(Console.ReadLine());
            //
            // if (year%4 == 0)
            // {
            //     if (year%100 == 0)
            //     {
            //         if (year % 400 == 0)
            //         {
            //             Console.WriteLine("La nam nhuan");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Khong phai nam nhuan");
            //         }
            //     }
            //     else
            //     {
            //         Console.WriteLine("La nam nhuan");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Khong phai nam nhuan");
            // }
            
            int nam;
            bool chon = true;
            do
            {
                Console.Write("Nhap nam: ");
                nam = int.Parse(Console.ReadLine());
                if (nam < 0)
                {
                    Console.WriteLine("Nhap lai nam");
                    continue;
                }
                else
                {
                    if (nam % 4 == 0)
                    {
                        if (nam % 100 == 0)
                        {
                            if (nam % 400 == 0)
                            {
                                Console.WriteLine($"{nam} la nam nhuan.");
                            }
                            else
                            {
                                Console.WriteLine($"{nam} khong phai nam nhuan.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{nam} la nam nhuan.");
                        }
                    }
                    else
                        Console.WriteLine($"{nam} khong phai nam nhuan.");
                }
                Console.WriteLine("True de quay lai, false de thoat.");
                chon = Boolean.Parse(Console.ReadLine());
                if (chon == false)
                {
                    Console.WriteLine("Ban da thoat.");
                }
            } while (chon == true);
        }
    }
}