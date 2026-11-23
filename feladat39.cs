using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat39
{
    internal class feladat39
    {
        static void Main(string[] args)
        {
            int[] a = { 4, -2, 7, 0, -5, 3, -1, 0, -9, 2, -4, 6 };
            int i = 0;
            while (i < a.Length && a[i] != 0)
            {
                i++;
            }

            int db = 0;
            if (i < a.Length)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < 0)
                    {
                        db++;
                    }
                }
                Console.WriteLine($"Az első nulla után {db} negatív elem található.");
            }
            else
            {
                Console.WriteLine("A sorozatban nincs nulla értékű elem.");
            }

        }
    }
}
