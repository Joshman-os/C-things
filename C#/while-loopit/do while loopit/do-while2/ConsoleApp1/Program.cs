using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kesk;
            int times = 0;
            do
            {
                Console.WriteLine("syötä arvosana: ");
                kesk = int.Parse(Console.ReadLine());
                times++;
            } while (kesk >= 0);
            if (kesk * times <= 0)
            {
                Console.WriteLine(kesk * -1 * times + " on arvosanasi keskiarvo");
            }
            else
            {
                Console.WriteLine(kesk * times + " on arvosanasi keskiarvo");
            }
        }
    }
}
