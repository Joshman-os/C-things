using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna korko, säästö ja tavoitesumma");
            double Korko = double.Parse(Console.ReadLine());
            double Säästö = double.Parse(Console.ReadLine());
            double TavoiteSumma = double.Parse(Console.ReadLine());
            int vuosi = 0;


            while (Säästö <= TavoiteSumma)
            {
                Säästö += (Säästö * (Korko / 100));
                vuosi++;
            }
            Console.WriteLine("{0} vuoden jälkeen, Säästö pääsi tavoitteeseen {1}$ korolla {2}%", vuosi, TavoiteSumma, Korko);
        }
    }
}
