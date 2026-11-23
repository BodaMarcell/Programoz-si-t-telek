using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat32
{
    internal class feladat32
    {
        static void Main(string[] args)
        {
            double[] vizallasok = { 5.4, 6.1, 7.8, 8.9, 9.2, 8.7, 7.3, 6.5, 5.9, 5.2 };
            int i = 0;
            while (i < vizallasok.Length && vizallasok[i] != 9.2)
            {
                i++;
            }
            bool volte = false;
            if(i  < vizallasok.Length) {volte = true;}
            Console.WriteLine(volte);
        }
    }
}
