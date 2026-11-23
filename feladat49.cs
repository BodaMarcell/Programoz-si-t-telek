using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat49
{
    internal class feladat49
    {
        static void Main(string[] args)
        {
            string[] nevek = { "Anna", "Béla", "Csaba", "Dóra" };
            int[] indulas = { 600, 605, 610, 615 }; 
            int[] erkezes = { 652, 648, 665, 655 };   

            int min = 0;

            for (int i = 1; i < nevek.Length; i++)
            {
                int aktualisIdo = erkezes[i] - indulas[i];
                int minIdo = erkezes[min] - indulas[min];

                if (aktualisIdo < minIdo)
                {
                    min = i;
                }
            }

            Console.WriteLine($"Győztes: {nevek[min]}");
        }
    }
}
