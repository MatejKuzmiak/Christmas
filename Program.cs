using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merry Christmas \n");

            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 4; j >= i; j--)
                {
                    Console.Write(" ");
                }

                for (k = 1; k <= (2 * i - 1); k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   | |");

            Console.ReadKey();
        }
    }
}
