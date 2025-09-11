using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            do
            {
                Console.Write("1.");
                int m = 0;
                while(int.TryParse(Console.ReadLine(), out m));

                Console.Write("2.");
                int n = 0;
                while(int.TryParse(Console.ReadLine(), out n)); 

                int r = m % n; 
                int.TryParse(Console.ReadLine(), out r);
 
                while (r != 0)
                {
                    {
                        m = n;
                        n = r;
                        r = m % n;
                    }
                    Console.WriteLine($"lnko: {n}");

                }

            } while (true);
        }
    }
}

        
