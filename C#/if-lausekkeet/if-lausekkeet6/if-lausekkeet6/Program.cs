using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lausekkeet6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä kolme sivun pituutta");
            int pituusa = int.Parse(Console.ReadLine());
            int pituusb = int.Parse(Console.ReadLine());
            int pituusc = int.Parse(Console.ReadLine());
            if (pituusa == pituusb && pituusb == pituusc)
            {
                Console.WriteLine("syntyy kolmio");
            }
            else if (pituusa == pituusb + pituusc)
            {
                Console.WriteLine("syntyy kolmio");
            }
            else if (pituusb == pituusc + pituusa)
            {
                Console.WriteLine("syntyy kolmio");
            }
            else if (pituusc == pituusc + pituusa)
            {
                Console.WriteLine("syntyy kolmio");
            }











            }
    }
}

