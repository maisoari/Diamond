using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x;
            int n = 0, y = 0, m = 0;

            Console.WriteLine("Anna rivien määrä");
            x = Console.ReadLine();
            n = Convert.ToInt32(x);

            m = n;

            for (int i = 0; i < n; i++)
            {   

                     for(int z=m; z>0; z--) { Console.Write(" "); }
                         m = m - 1;
                
                
                for (int j=0; j <= y; j++)
                {                                                      
                    Console.Write("*");
                }
                     y = y + 2;

                Console.WriteLine();
            }


           
            
            n = n - 1;
            m = n;
            for (int i = 0; i < n; i++)
            { 
                m = m + 1;

                for (int z = n; z <= m; z++) { Console.Write(" "); }
               


                for (int j = 4; j <= y; j++)
                {
                    Console.Write("*");
                }
                y = y - 2;

                Console.WriteLine();
            }








            Console.ReadLine();
        }
    }
}
