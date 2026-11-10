using System;
using System.Collections.Generic;
using System.Text;

namespace f3
{
    internal class feladat3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ird be a kivant szamot:");
            int n = int.Parse(Console.ReadLine());
            int osszeg = 0;
            for (int i = 0; i <= n; i++)
            {
                osszeg += i;
            }
            Console.WriteLine(osszeg);
        }
    }
}
