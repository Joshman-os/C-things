using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minuutit;
            int tunnit;

            Console.WriteLine("anna sekuntteja");
            int sekunnit = int.Parse(Console.ReadLine());
            tunnit = sekunnit / 3600;
            minuutit = sekunnit / 60;
            Console.WriteLine(tunnit + " tuntia,  " + minuutit + " minuuttia, ja " + sekunnit + " sekunttia");

        }
    }
}
