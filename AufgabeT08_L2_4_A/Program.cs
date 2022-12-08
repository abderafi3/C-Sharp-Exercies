using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L2_4_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gr;
            Console.Write("Geben Sie die Größe des Baumes ein: ");
            gr = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < gr; j++)
            {
                for (int i = 0; i < gr -1 - j; i++)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < 2 * j + 1; i++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
