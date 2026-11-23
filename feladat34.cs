using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat34
{
    internal class feladat34
    {
        static void Main(string[] args)
        {
            int[] lottoszamok = { 12, 27, 55, 68, 84 };
            int i = 0;
            while (i < lottoszamok.Length && lottoszamok[i] != 55)
            {
                i++;
            }

            bool vane = false;
            if (lottoszamok.Length > i) { vane = true; }
            Console.WriteLine(vane);
        }
    }
}
