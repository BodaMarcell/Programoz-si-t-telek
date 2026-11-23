using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat46
{
    internal class feladat46
    {
        static void Main(string[] args)
        {
            int[] magassag = { 120, 45, 0, 0, 80, 150, 0, 0, 210 };

            int i = 0;
            while (i < magassag.Length-1 && magassag[i] != 0)
            {
                i++;
            }
            bool voltTenger = false;
            if(i < magassag.Length) { voltTenger = true; }

            int j = i + 1;
            while (j < magassag.Length-1 && magassag[j] == 0)
            {
                j++;
            }
            while (j < magassag.Length-1 && magassag[j] > 0)
            {
                j++;
            }
            bool voltSziget =false;
            if(j < magassag.Length) { voltSziget=true; }

            Console.WriteLine($"Jártunk tenger felett: {voltTenger}");
            Console.WriteLine($"Átrepültünk sziget felett: {voltSziget}");
        }
    }
}
