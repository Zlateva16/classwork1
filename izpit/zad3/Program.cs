using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            var broinoshtuvki = int.Parse(Console.ReadLine());
            var destinaciq = Console.ReadLine();
            var tipstaq = Console.ReadLine();
            var razhodi = 1;
            if (destinaciq== "Maldives")
            {
                if (tipstaq== "beach villa")
                {
                    razhodi = broinoshtuvki * 380;
                }
                else
                {
                    if (tipstaq== "apartment")
                    {
                       razhodi = broinoshtuvki * 450;
                    }
                }
            }
            else
            {
                if (destinaciq== "Bora Bora")
                {
                    if (tipstaq == "beach villa")
                    {
                        razhodi = broinoshtuvki * 350;
                    }
                    else
                    {
                        if (tipstaq == "apartment")
                        {
                             razhodi = broinoshtuvki * 420;
                        }
                    }
                }
                else
                {
                    if (destinaciq == "Singapore")
                    {
                        if (tipstaq == "beach villa")
                        {
                          razhodi = broinoshtuvki * 390;
                        }
                        else
                        {
                            if (tipstaq == "apartment")
                            {
                                razhodi = broinoshtuvki * 490;
                            }
                        }
                    }
                }
            }
            Console.WriteLine("They have to spend {0:F2} leva.",razhodi);
            Console.ReadKey();
        }
    }
}
