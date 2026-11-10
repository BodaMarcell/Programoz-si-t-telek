using System;
using System.Collections.Generic;
using System.Text;

namespace f5
{
    internal class feladat6
    {
        static void Main(string[] args)
        {
            List<double> Homersekletek = new List<double>() {29.5,28,25,22.5,11.1,7,5,4.9};
            bool monoton = true;
            double elozo = 0;
            for (int i = 1; i< Homersekletek.Count; i++)
            {
                elozo = Homersekletek[i-1];
                if(elozo < Homersekletek[i])
                {
                    monoton = false;
                }
            }
            if (monoton) 
            {
                Console.WriteLine("monoton fogyo");
            }
            else
            {
                Console.WriteLine("nem monoton fogyo");
            }

        }
    }
}
