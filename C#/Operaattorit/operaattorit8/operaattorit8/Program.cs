using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna kolme kokonaislukua");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("laskeva järjestys: " + (a > b && b > c));
            Console.WriteLine("nouseva järjestys " + (a < b&&b<c ));
            Console.WriteLine("sama luku "+(a==b && b==c));
        }
    }
}
