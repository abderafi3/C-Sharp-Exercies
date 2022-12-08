using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_T08_L1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double avg;
            double[] arrDouble = new double[10] { 1.2, 2.3, 3.8, 4.2, 5.9, 2.3, 9.2, 6.7, 4.9, 7.7 };
            avg = arrDouble.Average();
            foreach (double i in arrDouble) 
            { 
                if (i > avg)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"{avg} ");
            foreach (double i in arrDouble)
            {
                if (i< avg)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }
    }
}
