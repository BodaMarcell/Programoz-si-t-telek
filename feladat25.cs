using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat25
{
    internal class feladat25
    {
        static void Main(string[] args)
        {
            int[] pontok = { 41, 13, 51, 51, 67, 88, 21 };
            int db = 0;
            for (int i = 0; i < pontok.Length; i++)
            {
                if( pontok[i] < 20)
                {
                    db++;
                }
            }
            Console.WriteLine(db);
        }
    }
}
