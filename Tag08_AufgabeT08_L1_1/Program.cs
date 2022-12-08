using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag08_AufgabeT08_L1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1, j = 100; i < 10 || j < 1000; i++, j += 100) 
            {
                Console.WriteLine(i + j + " ");
            }
        }
    }
}
