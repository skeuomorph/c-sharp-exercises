﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace math_thing
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double hits = 0; double trials = 0;
                Random dart = new Random();

                Console.WriteLine("Enter number of trials:");
                double.TryParse(Console.ReadLine(), out trials);

                for (int i = 1; i <= trials; i++)
                {
                    double x = dart.Next(0, 36);
                    double y = dart.Next(0, 36);

                    if (1000 < (x) * (y - x) * (36 - y) || 1000 < (y) * (x - y) * (36 - x))
                    {
                        hits = hits + 1;
                        //Console.Write("hit ");
                    }
                    else
                    {
                        //Console.Write("miss ");
                    }
                }

                double p = hits / trials;

                Console.WriteLine(p); Console.WriteLine();
            }
        }
    }
}

