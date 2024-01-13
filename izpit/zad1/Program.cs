using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cenazanaem = double.Parse(Console.ReadLine());
            var cenazahrana = 3 * cenazanaem;
            var cenazanapitki = cenazahrana - (cenazahrana * 20) / 100;
            var cenazaukrasa = 0.1 * (cenazahrana + cenazanapitki);
            var obshto = cenazanaem + cenazanapitki + cenazaukrasa + cenazahrana;
            Console.WriteLine("{0:F2}",obshto);
            Console.ReadKey();
        }
    }
}
