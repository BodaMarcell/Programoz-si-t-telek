using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat18
{
    internal class feladat18
    {
        static void Main(string[] args)
        {
            int[] Letszamok = { 3, 12, 5, 4, 6 };
            double[] Jovedelem = { 900000, 1200, 20000000, 320303203, 222002002 };
            double minimumber = 280000;
            int db = 0;
            for (int i = 0; i < Letszamok.Length; i++) 
            {
                if(Jovedelem[i] / Letszamok[i] < minimumber)
                {
                    db++;
                } 
            }
            Console.WriteLine(db);
        }
    }
}
