using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syöttö_ja_tulostus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vastaus1;
            int vastaus2;
            Console.WriteLine("syötä kaksi lukua");
            
            bool validinput1 = int.TryParse(Console.ReadLine(), out vastaus1);
            bool validinput2 = int.TryParse(Console.ReadLine(), out vastaus2);
            if (validinput1 && validinput2)
            {
                Console.WriteLine(vastaus1 + vastaus2 + " on lopputulos");
            }
            else
            {
                Console.WriteLine("virheelliset luvut");
            }
        }
    }
}
