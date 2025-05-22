using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopit6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int luku;
            int kertoma = 1;
            luku = int.Parse(Console.ReadLine());
            while (counter < 10)
            {
                Console.WriteLine(luku * kertoma); counter++; kertoma++;
            }
        }
    }
}
