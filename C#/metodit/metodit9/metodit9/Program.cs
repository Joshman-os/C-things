using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit9
{
    internal class Program
    {
        static void swap(ref int x, ref int y)
        {

            int tmp = x;
            x = y; y = tmp;

        
        }
        static void Main(string[] args)
        {
            int x=10;
            int y=5;

            swap(ref x, ref y);
            Console.WriteLine(x + " " +y);
        }
    }
}
