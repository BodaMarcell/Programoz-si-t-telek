using System;
using System.Collections.Generic;
using System.Text;

namespace f4
{
    internal class feladat4
    {
        static void Main(string[] args)
        {
            List<int> jegyek = new List<int>() {4,5,5,5,5,5,5,5,5,5};
            bool kituno = true;
            for (int i = 0; i < jegyek.Count; i++)
            {
                if(jegyek[i] < 5)
                {
                    kituno=false;
                }
            }
            if (kituno) 
            {
                Console.WriteLine("A tanulo kintuno");
            }
            else
            {
                Console.WriteLine("A tanulo nem kituno");
            }
        }
    }
}
