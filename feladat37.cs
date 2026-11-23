using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat37
{
    internal class feladat37
    {
        static void Main(string[] args)
        {
            int n = 5;
            int szorzat = 1;

            for (int i = 1; i <= n; i++)
            {
                szorzat = szorzat * i;
            }

            Console.WriteLine(szorzat);
        }
    }
}
