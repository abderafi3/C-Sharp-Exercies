using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeT08_L2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie eine Zahl ein");
            string zahl = Console.ReadLine();
            int sum = 0;
            foreach (char i in zahl)
            {
                int j = Int16.Parse($"{i}");
                sum += j;
            }
            Console.WriteLine($"Die Quersumme der Eingegebenen Zahl ist: {sum}");
        }
    }
}
