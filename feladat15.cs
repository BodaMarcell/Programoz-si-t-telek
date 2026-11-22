using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat15
{
    internal class feladat15
    {
        static void Main(string[] args)
        {
            double[] eredmenyek = { 40, 24, 51, 51, 120, 21, 51, 51, 31, 41, 22, 61, 35, 56, 44,20 };
            int otosszint = 35;
            double db = 0;
            for (int i = 0; i < eredmenyek.Length; i++) 
            {
                if(eredmenyek[i] < otosszint)
                {
                    db ++;s
                }
            }
            Console.WriteLine($"Az osztálybol: { db / eredmenyek.Length * 100}%-nak sikerült az ötös szint");
        }
    }
}
