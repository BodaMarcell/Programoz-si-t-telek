using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat38
{
    internal class feladat38
    {
        static void Main(string[] args)
        {
            int[] arak = { 1000, 500, 2500, 5150, 10000 };
            int ossz = 0;
            for (int i = 0; i < arak.Length; i++) 
            {
                ossz += arak[i];
            }
            Console.WriteLine(ossz);
        }
    }
}
