using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int num = 10; num <= 20; num++) 
            {
                Console.WriteLine("luku on: " + num);
                Console.WriteLine("neliö on: " + num*num);
                Console.WriteLine();
            }
        }
    }
}
