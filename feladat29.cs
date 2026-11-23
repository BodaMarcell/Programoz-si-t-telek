using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat29
{
    internal class feladat29
    {
        static void Main(string[] args)
        {
            string[] Nevnapok = { "Fruzsina", "Ábel", "Benjámin", "Leóna", "Simon", "Boldizsár", "Attila", "Gyöngyvér", "Marcell", "Melánia", "Ágota", "Ernő", "Veronika", "Bódog", "Lóránd", "Gusztáv", "Antal", "Piroska", "Sára", "Fábián", "Ágnes", "Artúr", "Mária", "Timót", "Pál", "Paula", "Angelika", "Károly", "Adél", "Martina", "Gerda" };
            int i = 0;
            while (i < Nevnapok.Length && Nevnapok[i] != "Mária")
            {
                i++;
            }

            bool van = i < Nevnapok.Length;

            if (van)
            {
                Console.WriteLine($"Januárban van Mária névnap: január {i + 1}-én.");
            }
            else
            {
                Console.WriteLine("Januárban nincs Mária névnap.");
            }
        }
    }
}
