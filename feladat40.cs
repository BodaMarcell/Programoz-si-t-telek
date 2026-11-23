using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat40
{
    internal class feladat40
    {
        static void Main(string[] args)
        {
            string szoveg = "Répa retek mogyoro koran reggele rikant a rigo";
            string[] szavak = szoveg.Split(new char[] {' '});
            int db = 0;
            for (int i = 0; i < szavak.Length; i++)
            {
                if (szavak[i].ToLower() == "a")
                {
                    db++;
                }
            }

            Console.WriteLine($"Az a db : {db}");
        }   
    }
}
