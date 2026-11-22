using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat14
{
    internal class feladat14
    {
        static void Main(string[] args)
        {
            double[] szamok = { 1.1, 52, 52, 5, 5, 65, 6, 65, 65, 43, 0.422, -11, 62, -52 };
            int megadottszam = 50;
            int db = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if(szamok[i]< megadottszam)
                {
                    db++;
                }
            }
            Console.WriteLine(db);
        }
    }
}
