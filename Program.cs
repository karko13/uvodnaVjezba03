using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace djeljenje
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, y;
            a = 100;
            b = 3;
            x = a / b;
            y = a % b;

            Console.WriteLine(a + " djeljeno sa " + b + " je " + x + " s ostatkom  " + y);
            
            Console.ReadKey();
        }
    }
}
