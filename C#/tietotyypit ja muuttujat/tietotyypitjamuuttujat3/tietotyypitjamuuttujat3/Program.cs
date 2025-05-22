using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mikä on kulmion vertikaalisen sivun pituus");
            int leveys = int.Parse(Console.ReadLine());
            Console.WriteLine("mikä on kulmion horisontaalisen sivun pituus");
            int korkeus = int.Parse(Console.ReadLine());
            Console.WriteLine("pinta-ala = " + korkeus * leveys);
        }
    }
}
