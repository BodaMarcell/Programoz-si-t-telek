using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat8
{
    internal class feladat8
    {
        static void Main(string[] args)
        {
            string[] honapNevek ={"január","február","március","április","május","június","július","augusztus","szeptember","október","november","december"};

            string honap = "december";
            int i = 0;
            while (honapNevek[i] != honap)
            {
                i++;
            }
            Console.WriteLine(i+1);

        }
    }
}
