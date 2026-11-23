using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat44
{
    internal class feladat44
    {
        static void Main(string[] args)
        {
            string[] r = { "répa", "retek", "mogyoro", "korán", "reggel", "rikant", "rigó" };
            string magasBetuk = "eéiíöőüű";
            string melyBetuk = "aáoóuú";

            int magasDb = 0;
            int melyDb = 0;
            int vegyesDb = 0; ;

            for (int i = 0; i < r.Length; i++)
            {
                bool vanMagas = false;
                bool vanMely = false;
                string szo = r[i].ToLower();

                for (int j = 0; j < szo.Length; j++)
                {
                    for (int k = 0; k < magasBetuk.Length; k++)
                    {
                        if (szo[j] == magasBetuk[k]) vanMagas = true;
                    }
                    for (int k = 0; k < melyBetuk.Length; k++)
                    {
                        if (szo[j] == melyBetuk[k]) vanMely = true;
                    }
                }

                if (vanMagas && vanMely) vegyesDb++;
                else if (vanMagas) magasDb++;
                else if (vanMely) melyDb++;
            }

            Console.WriteLine($"Magas: {magasDb}, Mély: {melyDb}, Vegyes: {vegyesDb}");
        }
    }
}
