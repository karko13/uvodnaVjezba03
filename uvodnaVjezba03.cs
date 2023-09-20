using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            ajde:
            Console.WriteLine(" molim vas upišite prvi broj:  ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("molim vas upisite drugi broj: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("molim  vas upisite treci broj: ");
            c = double.Parse(Console.ReadLine());
            if(a <=0)
            {
                Console.WriteLine("stavili ste broj koji se ne moze koristiti ");
                goto ajde;
            }
            if(b <=0)
            {
                Console.WriteLine("stavili ste broj koji se ne moze koristitit ");
                goto ajde;
            }
            if(c <=0) 
            {
                Console.WriteLine("stavili ste broj koji se ne moze korititi ");
                goto ajde;
            }
            if((c*c)==(a*a)+(b*b))
            {
                Console.WriteLine("trokut je pravokutan BRAVO!!!");
            }
            else
            {
                Console.WriteLine(" trokut nije pravokutan ");
            }
            Console.ReadKey();
        }
    }
}
