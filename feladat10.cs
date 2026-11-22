using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat10
{
    internal class feladat10
    {
        static void Main(string[] args)
        {
            int[] Evszamok = { 895, 1222, 1526, 1864 , 1914 ,1991, 2004};
            int aranbulla = 1222;
            int i = 0;
            while (Evszamok[i] != aranbulla) 
            {
                i++;
            }
            Console.WriteLine($"Az aranbulla kiadásának éve a {i+1}. elem a tömbben.");
        }
    }
}
