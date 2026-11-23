using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat35
{
    internal class feladat35
    {
        static void Main(string[] args)
        {
            string[] konyvek = { "Rumini", "Harry Potter", "Egri Csillagok", "stb" };
            int i = 0;
            while (i < konyvek.Length && konyvek[i] != "Egri Csillagok")
            {
                i++;
            }
            bool vane = false;
            if (i < konyvek.Length)
            {
                vane = true;
            }
            Console.WriteLine(vane);
        }
    }
}
