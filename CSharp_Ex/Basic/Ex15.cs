using System;

namespace CSharp_Ex.Basic
{
    public class Ex15
    {
        static String str;
        public static void Ex15_main()
        {
            Console.WriteLine("Input here:");
            str = Console.ReadLine();
            // DaoNguoc();
            // InHoaVaInThuong();
            // CatChuoi();
            // DemSoLanXuatHienCuaE();
            DemSoLanXuatHienCuaE2();
            string daochuoi = DaoNguoc2(str);
            Console.WriteLine("\nDao nguoc chuoi: " +daochuoi);
        }

        static void DaoNguoc()
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
        }

        static string DaoNguoc2(string index)
        {
            {
                char[] arr = index.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }

        }

        static void InHoaVaInThuong()
        {
            Console.Write(str.ToLower());
            Console.WriteLine();
            Console.Write(str.ToUpper());
        }

        static void CatChuoi()
        {
            string result = str.Substring(12, 4);
            Console.WriteLine(result);
        }
        
        static void DemSoLanXuatHienCuaE()
        {
            
            int e = 0;
            int a = 0;
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[i] == 'e')
                {
                    index++;
                }

                if (index > e)
                {
                    e = index;
                }
            }
            Console.WriteLine($"Ki tu 'e' da xuat hien {e}");
        }

        static void DemSoLanXuatHienCuaE2()
        {
            int vitri = 0;
            int lan = -1;
            int idx = -1;
            char solan = 'e';
            while (vitri != -1)
            {
                vitri =str.IndexOf(solan, idx + 1);//Sử dụng IndexOf để tìm vị trí cụ thể của e
                lan += 1;
                idx = vitri;
            }
            Console.Write("e da xuat hien:" + lan + " lan.");
        }
        
    }
}