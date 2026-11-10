using System;
using System.Collections.Generic;
using System.Text;

namespace f2
{
    internal class feladat2
    {
        static void Main(string[] args)
        {
            List<string> betuk = new List<string>() {"p","h","p"," ","e","c","h","o"};
            string szo = " ";
            for(int m = 0; m < betuk.Count; m++)
            {
                szo += betuk[m];
            }
            Console.WriteLine(szo);
        }
    }
}
