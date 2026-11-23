using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat31
{
    internal class feladat31
    {
        static void Main(string[] args)
        {
            int[] Homersekletek = {-12, -8, 2, -2, -3, 4, 2, -2, 6, 3, 1, -5};
            int db = 0;
            for (int i = 0; i < Homersekletek.Length; i++) 
            {
                if (Homersekletek[i]< 0)
                {
                    db++;
                }
            }
            Console.WriteLine(db);
        }
    }
}
