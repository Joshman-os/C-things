using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä luku");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("luku on negatiivinen " + (a < 0)); 
            Console.WriteLine("luku on nolla " + (a == 0));
            Console.WriteLine("luku on positiivinen " + (a > 0));
        }
    }
}
