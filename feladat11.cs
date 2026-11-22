using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat11
{
    internal class feladat11
    {
        static void Main(string[] args)
        {
            double[] Szamok = { 52, 21, 65, 2001, 09, 11,2.2 };
            int i = 0;
            while (i < Szamok.Length && Szamok[i] > 5) 
            {
                i++;
            }
            if (i < Szamok.Length)
            {
                Console.WriteLine(Szamok[i]);
            }
            else { Console.WriteLine("nincs ilyen elem"); }
        }
    }
}
