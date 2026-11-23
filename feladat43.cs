using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat43
{
    internal class feladat43
    {
        static void Main(string[] args)
        {
            int[] szamok = { -4, 0, 7, -1, 0, 5, 12, -8, 3 };
            int negativdb = 0;
            int nulladb = 0;
            int pozitivdb = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < 0)
                {
                    negativdb++;
                }
                else if (szamok[i] == 0)
                {
                    nulladb++;
                }
                else
                {
                    pozitivdb++;
                }
            }

            Console.WriteLine($"Negatív: {negativdb}, Nulla: {nulladb}, Pozitív: {pozitivdb}");
        }
    }
}
