using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit3
{
    internal class Program
    {
        static int square(int a) { return a * a; }
        static void Main(string[] args)
        {
            Console.WriteLine(square(int.Parse(Console.ReadLine())));
            
        }
    }
}
