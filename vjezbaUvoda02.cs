using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pocetnaVjezba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10 , b = 7;
            double c = 12.5, d = 16.7;
            double  rezultat = 0;
            rezultat = a + b + c + d % 4 ;
            Console.WriteLine("rezultat je " + rezultat );
            Console.ReadKey();
        }
    }
}
