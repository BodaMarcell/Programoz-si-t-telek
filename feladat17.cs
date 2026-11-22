using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat17
{
    internal class feladat17
    {
        static void Main(string[] args)
        {
            string elsoVersszak = "Nyári napnak alkonyulatánál Megállék a kanyargó Tiszánál Ott, hol a kis Túr siet beléje, Mint a gyermek anyja kebelére.";

            string masodikVersszak = "A folyó oly símán, oly szelíden Ballagott le parttalan medrében, Nem akarta, hogy a nap suára Megbotoljék habjai fodrába.";

            string maganhangzok = "aáeéiíoóöőuúüűAÁEÉIÍOÓÖŐUÚÜŰ";

            int db1 = 0;
            for (int i = 0; i < elsoVersszak.Length; i++)
            {
                if (maganhangzok.Contains(elsoVersszak[i]))
                {
                    db1++;
                }
            }

            int db2 = 0;
            for (int i = 0; i < masodikVersszak.Length; i++)
            {
                if (maganhangzok.Contains(masodikVersszak[i]))
                {
                    db2++;
                }
            }

            if (db1 > db2)
            {
                Console.WriteLine("Az első versszakban van több magánhangzó.");
            }
            else if (db2 > db1)
            {
                Console.WriteLine("A második versszakban van több magánhangzó.");
            }
            else
            {
                Console.WriteLine("A két versszakban ugyanannyi magánhangzó van.");
            }
        }
    }
}
