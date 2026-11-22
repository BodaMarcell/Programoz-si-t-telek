using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat19
{
    internal class feladat19
    {
        static void Main(string[] args)
        {
            int[] Magassagok = { 140, 200, 201, 175, 166, 175, 187, 164, 174, 178, 182, 183 };
            string[] Nevek = { "Bence", "Hanna", "Máté", "Anna", "Levente", "Zoé", "Dániel", "Luca", "Ádám", "Eszter", "Marcell", "Nóra" };
            int min = 0;
            for (int i = 0;i < Magassagok.Length; i++)
            {
                if (Magassagok[i] < Magassagok[min])
                {
                    min = i;
                }
            }
            Console.WriteLine($"{Nevek[min]} a legalacsonyabb");
        }
    }
}
