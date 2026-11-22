using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat13
{
    internal class feladat13
    {
        static void Main(string[] args)
        {
            double[] idopontok = { 6.15, 6.35, 6.55, 7.12, 7.26, 7.38, 7.52, 8.10 };

            int i = 0;
            while(!(idopontok[i] < 7.45 && idopontok[i] > 7.30))
            {
                i++;    
            }
            Console.WriteLine(idopontok[i]);
        }
    }
}
