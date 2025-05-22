using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypit_ja_muuttujat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            Console.WriteLine("ilmoita halkaisija");
           var halk = int.Parse(Console.ReadLine());
            Console.WriteLine(halk * pi + " on ympärysmitta");
        }
    }
}
