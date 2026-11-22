using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat7
{
    internal class feladat7
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int i = 0;
            while (i < szamok.Length && szamok[i] % 9 != 0) 
            {
                i++;
            }
            Console.WriteLine(szamok[i]);
        }
    }
}
