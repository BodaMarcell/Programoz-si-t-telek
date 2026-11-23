using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat41
{
    internal class feladat41
    {
        static void Main(string[] args)
        {
            string szoveg = "Süt a nap. A kutya az udvaron fut! Te is jössz?";
            int mondatDb = 0;
            int szoDb = 0;
            bool mondatszodb = false;

            for (int i = 0; i < szoveg.Length; i++)
            {
                char c = szoveg[i];
                if (char.IsLetterOrDigit(c) || c == '\'')
                {
                    if (!mondatszodb) { szoDb++; mondatszodb = true; }
                }
                else
                {
                    mondatszodb = false;
                    if (c == '.' || c == '!' || c == '?')
                    {
                        mondatDb++;
                        Console.WriteLine($"{mondatDb}. mondat: {szoDb} szó");
                        szoDb = 0;
                    }
                }
            }

            Console.WriteLine($"Összesen {mondatDb} mondat.");
        }
    }
}
