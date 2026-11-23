using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat47
{
    internal class feladat47
    {
        static void Main(string[] args)
        {
            string[] nevek = { "Kiss Beáta", "Kovács Kitti", "Szabó Eszter", "Kun Béla" };
            int max = 0;

            for (int i = 1; i < nevek.Length; i++)
            {
                if (nevek[i].Length > nevek[max].Length)
                {
                    max = i;
                }
            }

            Console.WriteLine(nevek[max]);
        }
    }
}
