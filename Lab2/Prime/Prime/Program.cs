﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            double r = 999999999;
            double a = 0;
            string s = System.IO.File.ReadAllText(@"C:\test\Textv.txt");
            string[] massiv = s.Split(' ');

            for (int i = 0; i < massiv.Length; i++)
            {
                a = Double.Parse(massiv[i]);
                for (int j = 1; j <= Math.Sqrt(a); j++)
                {
                    if (a % j == 0) k = k + 1;
                }
                if (k < 2) {if (r > a) { r = a; } }
                k = 0;
            }
            System.IO.File.WriteAllText(@"C:\test\Result1.txt", r.ToString());
        }
    }
}