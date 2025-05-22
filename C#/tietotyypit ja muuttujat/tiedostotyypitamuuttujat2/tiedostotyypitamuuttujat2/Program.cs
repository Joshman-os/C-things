using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostotyypitamuuttujat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double fallaccel = 9.81;
            Console.WriteLine("mikä on putoamisen aika?");
            var falltime = int.Parse(Console.ReadLine());
            Console.WriteLine(0.5 * fallaccel * falltime * falltime + " metriä sekunnissa");
        }
    }
}
