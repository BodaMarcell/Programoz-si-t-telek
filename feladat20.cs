using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat20
{
    internal class feladat20
    {
        static void Main(string[] args)
        {
            string[] honapNevek = { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            int[] bevetelek = { 720000, 735000, 750000, 740000, 780000, 820000, 760000, 760000, 790000, 810000, 830000, 950000 };
            int[] kiadasok = { 610000, 590000, 640000, 680000, 650000, 790000, 810000, 770000, 710000, 670000, 730000, 890000 };

            int max = 0;
            for (int i = 0; i < honapNevek.Length; i++) 
            {
                if (bevetelek[i] - kiadasok[i] > bevetelek[max] - kiadasok[max])
                {
                    max = i;
                }
            }
            Console.WriteLine(honapNevek[max]);
        }
    }
}
