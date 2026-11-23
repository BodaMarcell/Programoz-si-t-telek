using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat21
{
    internal class feladat21
    {
        static void Main(string[] args)
        {
            int[] szamok = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int min = 0;
            int max = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i]< szamok[min])
                {
                    min = i;
                }
                if (szamok[i]> szamok[max])
                {
                    max = i;
                }
            }
            Console.WriteLine($"Legnagyobb: {szamok[max]} , Legkisebb: {szamok[min]}");
        }
    }
}
