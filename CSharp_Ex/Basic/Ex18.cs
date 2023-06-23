using System;

namespace CSharp_Ex.Basic
{
    public class Ex18
    {
        
        public static void Ex18_main()
            {
                Console.WriteLine("Enter string: ");
                string str = Console.ReadLine();
        
                Console.WriteLine("Enter search string: ");
                string searchStr = Console.ReadLine();
        
                int vitri = 0;
                int lan = -1;
                int index = -1;

                while (vitri != -1)
                {
                    vitri = str.IndexOf(searchStr, index + 1);
                    lan++;
                    index = vitri;
                }
                Console.WriteLine($"The number of occurrences of {searchStr}: {lan} ");
                
                
            }
    }
}