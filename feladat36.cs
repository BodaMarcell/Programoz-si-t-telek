using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat36
{
    internal class feladat36
    {
        static void Main(string[] args)
        {
            string[] nevek = { "Kis József", "Sima József", "Nagy József", "Legnagyobb József" };
            int i = 0;
            while (i < nevek.Length && nevek[i] != "Nagy József")
            {
                i++;
            }

            bool vane = false;
            if (i < nevek.Length) { vane = true; }
            Console.WriteLine(vane);
        }
    }
}
