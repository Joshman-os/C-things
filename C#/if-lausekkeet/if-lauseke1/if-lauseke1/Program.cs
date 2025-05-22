using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lauseke1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta luku");
            int luku = int.Parse(Console.ReadLine());
            if (luku <= 0)
            {
                Console.WriteLine("lukusi on negatiivinen");
            }
            else if (luku == 0)
            {
                Console.WriteLine("lukusi on nolla");
            }
            else if (luku >= 1)
            {
                Console.WriteLine("lukusi on positiivinen");

            }
            if (luku%2 == 0)
            {
                Console.WriteLine("lukusi on jaettavissa kahdella");
            }
            else
            {
                Console.WriteLine("lukusi on pariton");
            }
        }
    }
}
