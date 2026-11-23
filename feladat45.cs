using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat45
{
    internal class feladat45
    {
        static void Main(string[] args)
        {
            int[] helyek = { 1, 1, 1, 0, 1, 1, 1, 1 };

            int i = 0;
            while (i < helyek.Length && helyek[i] != 0)
            {
                i++;
            }

            bool vane = false;
            if (i < helyek.Length) { vane = true; }
            Console.WriteLine(vane);

        }
    }
}
