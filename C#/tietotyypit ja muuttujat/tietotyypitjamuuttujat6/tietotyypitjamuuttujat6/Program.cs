using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lämpötila C");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine(celsius * 9 / 5 + 32 + " fahrenheittia");
        }
    }
}
