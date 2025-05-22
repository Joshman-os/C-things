using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_silmukka3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("aseta kaksi lukua: "); int luku1 = int.Parse(Console.ReadLine()); int luku2 = int.Parse(Console.ReadLine());
            while (luku1 >= 0 && luku2 >=0) { Console.WriteLine(luku1+luku2); }
        }
    }
}
