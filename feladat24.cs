using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat24
{
    internal class feladat24
    {
        static void Main(string[] args)
        {
            int[] osszegek = { 3200, 6400, 1850, 5000, 7900, 4120, 9300, 2750, 5400, 1290, 8150, 3600, 4990, 11200, 2300, 6750, 3890, 5250, 1540, 7400, 4600, 8900, 2100, 3450, 6100, 1780, 5800, 4300, 9650, 2900, 5010 };
            int db = 0;
            for (int i = 0; i < osszegek.Length; i++) 
            {
                if (osszegek[i] > 5000)
                {
                    db++;
                }
            }
            Console.WriteLine(db);
        
        }
    }
}
