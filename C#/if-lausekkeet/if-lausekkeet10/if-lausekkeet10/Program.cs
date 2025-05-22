using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lausekkeet10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta kaksi lukua ja laskutoimituksen merkki (+,-,*,/)");
            int lasku=int.Parse(Console.ReadLine());
            int lasku2=int.Parse(Console.ReadLine());
            string laskumerkki = Console.ReadLine();
            switch (laskumerkki)
            {
                case "+":
                    Console.WriteLine(lasku + lasku2);
                    break;
                case "-":
                    Console.WriteLine(lasku - lasku2);
                    break;
                case "*":
                    Console.WriteLine(lasku * lasku2);
                    break;
                case "/":
                    Console.WriteLine(lasku / lasku2);
                    break;
            }
        }
    }
}
