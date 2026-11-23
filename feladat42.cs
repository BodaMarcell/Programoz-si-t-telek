using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat42
{
    internal class feladat42
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 1, 2, 4, 4, 4, 7, 9, 9 };
            int kulonbozoDb = szamok.Length > 0 ? 1 : 0;

            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] != szamok[i - 1])
                {
                    kulonbozoDb++;
                }
            }

            Console.WriteLine(kulonbozoDb);
        }
    }
}
