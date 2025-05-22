using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna kaksi lukua");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            if (a == b)
            {
                Console.WriteLine(" luvut ovat yhtä suuria");
            }
            else Console.WriteLine(" luvut eivät ole yhtä suuria");
            if (a < b)
            {
                Console.WriteLine(" ensimmäinen luku on pienempi kuin toinen");
            }
            else Console.WriteLine(" toinen luku on pienempi kuin ensimmäinen");

        }
    }
}
