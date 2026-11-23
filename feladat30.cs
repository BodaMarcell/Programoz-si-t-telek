using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat30
{
    internal class feladat30
    {
        static void Main(string[] args)
        {
            int[] magassagok = { 4447, 3886, 2002, 1014, 2636 };
            int max = 0;
            for (int i = 0; i < magassagok.Length; i++) 
            {
                if(magassagok[i] > magassagok[max])
                {
                    max = i;
                }
            }
            Console.WriteLine(magassagok[max]);
        }
    }
}
