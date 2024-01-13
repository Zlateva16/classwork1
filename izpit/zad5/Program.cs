using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int k = 1; k < 10; k++)
                    {
                        for (int g = 1; g < 10; g++)
                        {
                            for (int m = 1; m < 10; m++)
                            {
                               
                                if (i+j+k==n&&g%2==0&&m==1)
                                {
                                    Console.Write($" {i}{j}{k}{g}{m}");
                                    count++;

                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Count of winner numbers: {count}" );
            Console.ReadKey();

        }
    }
}
