using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat48
{
    internal class feladat48
    {
        static void Main(string[] args)
        {
            double[] m = { 0.0, 0.8, 2.5, 4.1, 4.3, 3.0, 0.5, 0.0 };
            int maxhely = 0;

            for (int i = 1; i < m.Length - 1; i++)
            {
                double merdekseg = m[i + 1] - m[i];
                if (merdekseg < 0)
                {
                    merdekseg = -merdekseg;
                }
                double maxmeredekeseg = m[maxhely + 1] - m[maxhely];
                if (maxmeredekeseg < 0)
                {
                    maxmeredekeseg = -maxmeredekeseg;
                }
                if (merdekseg > maxmeredekeseg)
                {
                    maxhely = i;
                }
            }

            Console.WriteLine($"A(z) {maxhely + 1}. és {maxhely + 2}. mérés között a legmeredekebb.");
        }
    }
}
