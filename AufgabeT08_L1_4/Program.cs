using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, average = 0;
            double[] arrDouble = new double[5] { 1.2, 2.3, 3.8, 4.2, 5.9 };
            foreach (double i in arrDouble)
            {
                sum += i;
                average = sum / arrDouble.Length;

            }

            Console.WriteLine(average);

            //Console.WriteLine(arrDouble.Average());

        }
    }
}
