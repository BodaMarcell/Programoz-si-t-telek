using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat22
{
    internal class feladat22
    {
        static void Main(string[] args)
        {
            int[] szamok = { 5, 42, 723, 4267, 989, 100, 4, 345, 12, 10000 };

            int egydb = 0; 
            int kettodb = 0; 
            int haromdb = 0; 
            int negydb = 0;

            for (int i = 0; i < szamok.Length; i++)
            {

                if (szamok[i] < 10)
                {
                    egydb++;
                }
                else if (szamok[i] < 100)
                {
                    kettodb++;
                }
                else if (szamok[i] < 1000)
                {
                    haromdb++;
                }
                else if (szamok[i] < 10000)
                {
                    negydb++;
                }
            }
            Console.WriteLine($"egy jegyű: {egydb} db");
            Console.WriteLine($"ketto jegyű: {kettodb} db");
            Console.WriteLine($"harom jegyű: {haromdb} db");
            Console.WriteLine($"negy jegyű: {negydb} db");
        }
    
    }
}
