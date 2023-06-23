using System;

namespace CSharp_Ex.Basic
{
    public class Ex14
    {
        static string str;
        public static void Ex14_main()
        {
            Console.WriteLine("Enter strings: ");
            str = Console.ReadLine();
            // TachChuoi();
            // DaoNguoc();
            // DemSoTu();
            // Dem_So_Chu_ChuDacBiet();
            // NguyenAm_PhuAm();
            KyTuXuatHienNhieuNhat();
        }
        
        static void TachChuoi()
        {
            Console.Write("Chuoi sau khi duoc tach chuoi: ");
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+ " ");
            }
            Console.WriteLine();
        }

        static void DaoNguoc()
        {
            Console.Write("Chuoi sau khi duoc dao nguoc: ");
            for (int i = str.Length-1; i >= 0; i--)
            {
                Console.Write(str[i]+ " ");
            }
        }

        static void DemSoTu()
        {
            int index = 0;
            Console.Write("So tu cua chuoi la: ");
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    index++;
                }
            }
            Console.Write(index + 1);
        }

        static void Dem_So_Chu_ChuDacBiet()
        {
            int so = 0, chu = 0, dacbiet =0;
            // for (int i = 0; i < str.Length; i++)
            // {
            //     //dem so
            //     if (str[i] >= '0' && str[i] <= '9')
            //     {
            //         so++;
            //     }
            //     else if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
            //     {
            //         chu++;
            //     }
            //     else
            //     {
            //         dacbiet++;
            //     }
            // }
            // Console.WriteLine("So cac so trong chuoi la: "+ so);
            // Console.WriteLine("So cac chu trong chuoi la: "+ chu);
            // Console.WriteLine("So cac ki tu dac biet la: "+ dacbiet);
            int i = 0;
            do
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    so++;
                }
                else if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    chu++;
                }
                else
                {
                    dacbiet++;
                }
                i++;
            } while (i < str.Length);
            Console.WriteLine("So cac so trong chuoi la: "+ so);
            Console.WriteLine("So cac chu trong chuoi la: "+ chu);
            Console.WriteLine("So cac ki tu dac biet la: "+ dacbiet);
        }

        static void NguyenAm_PhuAm()
        {
            int nguyenAm=0, phuAm=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'u' || str[i] == 'e' || str[i] == 'O' || str[i] == 'a' || str[i] == 'i' 
                    || str[i] == 'U' || str[i] == 'E' || str[i] == 'O' || str[i] == 'A' || str[i] == 'I')
                {
                    nguyenAm++;
                }
                else
                {
                    phuAm++;
                }
            }
            Console.WriteLine("So nguyen am la: "+ nguyenAm);
            Console.WriteLine("So phu am la: "+ phuAm);
            
        }

        static void KyTuXuatHienNhieuNhat()
        {
            
            int nhieunhat = 0;
            int a = 0;
            
            for (int i = 0; i < str.Length-1; i++)
            {
                int index = 0;
                
                for (int j = i+1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        index++;
                    }
                    
                }

                if (index > nhieunhat)
                {
                    nhieunhat = index+1;
                    a = i;
                }
            }
            Console.WriteLine($"Ki tu {str[a]} da xuat hien {nhieunhat}");
        }
    }
}