using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat9
{
    internal class feladat9
    {
        static void Main(string[] args)
        {
            string[] Nevnapok = { "Malvina", "Petra", "Helga", "Ferenc", "Aurél", "Brúnó", "Amália", "Koppány", "Dénes", "Gedeon", "Brigitta", "Miksa", "Kálmán", "Helén", "Teréz", "Gál", "Hedvig", "Lukács", "Nándor", "Vendel", "Orsolya", "Előd", "Gyöngyi", "Salamon", "Blanka", "Dömötör", "Szabina", "Simon", "Nárcisz", "Alfonz", "Farkas" };
            string nev = "Lukács";
            int i = 0;
            while (Nevnapok[i] != nev) 
            {
                i++;
            }
            Console.WriteLine($"Lukácsnak {i + 1}.én/án van névnapja");

        }
    }
}
