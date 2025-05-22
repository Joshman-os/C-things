using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta luku");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("onko luku pariton " + (a % 2 == 0));
            Console.WriteLine("onko luku jaollinen kolmella "+(a % 3 == 0)); 
        }
    }
}
