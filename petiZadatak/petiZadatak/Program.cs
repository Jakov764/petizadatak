using System;
using System.Collections.Generic;

namespace cetvrtiZadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 40; a++)
            {
                for (int b = 1; b < 40; b++)
                {
                    for (int c = 1; c < 40; c++)
                    {
                        for (int d = 1; d < 40; d++)
                        {
                            for (int e = 1; e < 40; e++)
                            {
                                for (int f = 1; f < 40; f++)
                                {
                                    for (int g = 1; g < 40; g++)
                                    {
                                        if (a != b && a != c && a != d && a != e && a != f && a != g && b != a && b != c && b != d && b != e && b != g && c != a && c != b && c != d && c != e && c != f && c != g && d != a && d != b && d != c && d != e && d != f && d != g && e != a && e != b && e != c && e != d && e != f && e != g && f != a && f != b && f != c && f != d && f != e && f != g)
                                        {
                                            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", a, b, c, d, e, f, g);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.ReadKey();

        }
    }
}
