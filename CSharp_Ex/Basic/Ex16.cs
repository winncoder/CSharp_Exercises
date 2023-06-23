using System;

namespace CSharp_Ex.Basic
{
    public class Ex16
    {
        
        public static void Ex16_main()
        {
            String name;
            int id, chudien;
            double tiendien = 0;
            
            Console.WriteLine("Enter ID: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Chu dien: ");
            chudien = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Chu dien: {chudien}");
            if (chudien <= 199)
            {
                tiendien = chudien *1.2;
            }
            else if (chudien >= 200 && chudien <= 399)
            {
                tiendien = chudien * 1.5;
            }
            else if (chudien >= 400 && chudien <= 599)
            {
                tiendien = chudien * 1.8;
            }
            else if (chudien >= 600)
            {
                tiendien = chudien * 2;
            }

            if (chudien > 400)
            {
                tiendien = tiendien + (tiendien* 0.15);
            }
            
            Console.WriteLine($"Tien dien: {tiendien}");
            
        }
    }
}