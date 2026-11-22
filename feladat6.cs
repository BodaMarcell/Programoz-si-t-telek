using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat6
{
    internal class feladat6
    {
        static void Main(string[] args)
        {
            List<string> hetNapjai = new List<string>() {"hétfő","kedd","szerda","csütörtök","péntek","szombat","vasárnap" };
            string hetfo = "hétfő";
            int i = 0;
            while(i < hetNapjai.Count && hetNapjai[i] != hetfo)
            {
                i++;
            }

            bool vanE=false;

            if (i < hetNapjai.Count)
            {
               vanE = true;
            }
            Console.WriteLine(vanE);
        }
    }
}
