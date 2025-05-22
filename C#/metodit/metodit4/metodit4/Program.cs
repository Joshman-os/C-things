using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit4
{
    internal class Program
    {
        static int sum (int x, int y) { return x + y; }
        static void Main(string[] args)
        {
            Console.WriteLine(sum(int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine())));
        }
    }
}
