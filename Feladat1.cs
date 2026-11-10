using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTetelekFeladat1
{
    internal class Feladat1
    {
        static void Main(string[] args)
        {
            List<double> atlageredmenyekLST = new List<double>() { 4.2, 1.9, 5, 5, 5, 4, 2, 2.2, 3.5 };
            double osszatlag = 0;
            for (int i = 0; i < atlageredmenyekLST.Count; i++)
            {
                osszatlag += atlageredmenyekLST[i];
            }
            double osztalyatlag = Math.Round(osszatlag / atlageredmenyekLST.Count,2);
            Console.WriteLine(osszatlag);
        }
    }
}
