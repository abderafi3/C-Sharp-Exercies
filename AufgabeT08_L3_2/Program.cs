using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L3_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.Write("Geben Sie die Größe des Baumes ein: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((j <= i && j + i <= n - 1) || (j >= i && j + i >= n - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }

        //for (int i = 1; i < 4; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //        Console.Write("*");
        //    Console.WriteLine();

        //}
        //for (int i = 4; i >= 0; i--)
        //{
        //    for (int j = 1; j <= i; j++)
        //        Console.Write("*");
        //    Console.WriteLine();
        //}
        //Console.WriteLine();


    }

}
