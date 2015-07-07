using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("площадь = ");
            double S = Convert.ToDouble(Console.ReadLine());
            double r = 0.5*Math.Pow(S / Math.PI, 0.5);
            double V = S * Math.Pow( S / Math.PI, 0.5) / 6 ;
            Console.Write("радиус = " + r + "\n" + "обьём = " + V);
            Console.ReadKey();
        }
    }
}
