using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat26
{
    internal class feladat26
    {
        static void Main(string[] args)
        {
            string[] szavak = { "Boda", "Buzi", "boldog", "banán", "csavar", "tűz" };
            int bdb = 0;
            for (int i = 0; i < szavak.Length; i++)
            {
                if((szavak[i][0] == 'b' || szavak[i][0] == 'B')))
                {
                    bdb++;
                }
            }
            Console.WriteLine(bdb);

        }
    }
}
