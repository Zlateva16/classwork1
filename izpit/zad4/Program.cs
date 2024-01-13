using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            var broimateriali = int.Parse(Console.ReadLine());
            var vidmaterial = "";
            var counttitle = 0;
            var counttools = 0;
            var countpaint = 0;
            for (int i = 0; i < broimateriali; i++)
            {
                vidmaterial = Console.ReadLine();
                if (vidmaterial== "tile")
                {
                    counttitle++;
                }
                else
                {
                    if (vidmaterial == "tools")
                    {
                        counttools++;
                    }
                    else
                    {
                        if (vidmaterial == "paint")
                        {
                            countpaint++;
                        }

                    }

                }

            }
            Console.WriteLine("Tiles: {0}", counttitle);
            Console.WriteLine("Tools: {0}",counttools);
            Console.WriteLine("Paint: {0}",countpaint);
            Console.ReadKey();

        }
    }
}
