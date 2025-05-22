using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lauseke4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta ikäsi");
            int ikä = int.Parse(Console.ReadLine());
            if (ikä <= 3) { Console.WriteLine("olet " + ikä + " vuotias, olet vielä vasta vauva"); }
            else if (ikä <= 13) { Console.WriteLine("olet " + ikä + " vuotias, olet vasta pieni lapsi"); }
            else if (ikä <= 18) { Console.WriteLine("olet " + ikä + " vuotias, olet teini-ikäinen"); }
            else if (ikä <= 40) { Console.WriteLine("olet " + ikä + " vuotias, olet aikuinen"); }
            else if (ikä <= 65) { Console.WriteLine("olet " + ikä + " vuotias, olet keski-ikäinen"); }
            else if (ikä <= 999) { Console.WriteLine("olet " + ikä + " vuotias, olet jo aika vanha"); }

        }

    }
}

            
            
            

