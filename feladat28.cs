using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat28
{
    internal class feladat28
    {
        static void Main(string[] args)
        {
            int[] jegyek = { 2, 2, 2, 2, 2, 2, 2, 4, 5, 5, 5, 5, };
            int i = 0;
            while (jegyek[i] != 5) 
            {
                i++;
            }
            Console.WriteLine(jegyek[i]);
        }
    }
}
