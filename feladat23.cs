using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat23
{
    internal class feladat23
    {
        static void Main(string[] args)
        {
            string mondat = "Az a kocsi egy fa szállitós"; //cs gy sz egynek szamoltam
            int edb = 0;
            for (int i = 0; i < mondat.Length; i++) 
            {
                if (mondat[i] == 'e' || mondat[i] == 'E')
                {
                    edb++;

                }
            }
            Console.WriteLine(edb);
        }
    }
}
