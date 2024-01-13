using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cenaednateniska = int.Parse(Console.ReadLine());
            var broiteniski=int.Parse(Console.ReadLine());
            var broiqketa = int.Parse(Console.ReadLine());
            var broidunki= int.Parse(Console.ReadLine());
            var broipuloveri= int.Parse(Console.ReadLine());
            var bujet= double.Parse(Console.ReadLine());
            var cenaqke = cenaednateniska + (cenaednateniska * 40) / 100;
            var cenadunki = cenaqke - (cenaqke * 20) / 100;
            var cenapulover = cenadunki - 10;
            var krainacena = (broiteniski * cenaednateniska) + (broiqketa * cenaqke) + (broidunki * cenadunki) + (broipuloveri * cenapulover);
            if (krainacena<bujet)
            {
                Console.WriteLine("Yes! {0:F2} leva left.",bujet-krainacena);
            }
            else
            {
                Console.WriteLine("No! {0:F2} leva needed.",krainacena-bujet);
            }
            Console.ReadKey();

            2
        }
    }
}
