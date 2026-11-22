using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat12
{
    internal class feladat12
    {
        static void Main(string[] args)
        {
            int[] bevetel = { 14, 87, 3, 52, 69, 21, 95, 8, 44, 76, 31, 60, 19, 83, 47, 12, 91, 38, 65, 27, 73, 5, 58, 99, 16, 41, 82, 29, 64, 50 };

            int[] kiadas = { 42, 7, 68, 93, 15, 54, 28, 81, 36, 11, 79, 63, 2, 90, 48, 25, 71, 34, 88, 17, 56, 94, 9, 61, 39, 85, 22, 74, 45, 13 };

            int i = 0;
            while (i < bevetel.Length && kiadas[i] < bevetel[i])
            {
                i++;
            }
            if (i == bevetel.Length)
            {
                Console.WriteLine("Nem volt veszteséges nap");
            }
            else { Console.WriteLine($"{i+1}.je/a veszteséges nap volt"); }
        }
    }
}
