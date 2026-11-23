using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat33
{
    internal class feladat33
    {
        static void Main(string[] args)
        {
            int[] cpuArak = { 48900, 32500, 74000, 18990, 61200, 29400, 112500, 24800 };
            int i = 0;
            while (i < cpuArak.Length && !(cpuArak[i] < 20000))
            {
                i++;
            }
            bool vane = false;
            if (i < cpuArak.Length) { vane = true; }
            Console.WriteLine(vane);
        }
    }
}
