using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat16
{
    internal class feladat16
    {
        static void Main(string[] args)
        {
            string Versszak = "Nyári napnak alkonyulatánál Megállék a kanyargó TiszánálOtt, hol a kis Túr siet beléje,Mint a gyermek anyja kebelére.";

            string maganhangzok = "aáeéiíoóöőuúüűAÁEÉIÍOÓÖŐUÚÜŰ";
            int db = 0;
            for (int i = 0; i < Versszak.Length; i++)
            {
                if (maganhangzok.Contains(Versszak[i]))
                {
                    db++;
                }
            }
            Console.WriteLine(db);
        }
    }
}
