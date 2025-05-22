using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double korko = double.Parse(Console.ReadLine());
            double säästö = double.Parse(Console.ReadLine());
            if (korko == 5)
            {
                for (int num = 0; num < 11; num++)
                {
                    säästö += (korko / 100) * säästö;

                }
                Console.WriteLine(säästö);
            }
        }
    }
}
