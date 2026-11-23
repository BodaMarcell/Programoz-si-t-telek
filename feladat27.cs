using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat27
{
    internal class feladat27
    {
        static void Main(string[] args)
        {
            double[] Homersekletek = { 12.4, 14.1, 13.8, 16.5, 15.9, 17.2, 16.8, 14.7, 15.3, 18.0, 17.4, 16.1 };
            bool monoton = true;
            double elozo = 0;
            for (int i = 1; i < Homersekletek.Length; i++)
            {
                elozo = Homersekletek[i - 1];
                if (elozo > Homersekletek[i])
                {
                    monoton = false;
                }
            }
            if (monoton)
            {
                Console.WriteLine("nő");
            }
            else
            {
                Console.WriteLine("nem");
            }
        }
    }
}
