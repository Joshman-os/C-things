using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit5
{
    internal class Program
    {
        static void iseven (int n) 
        {
            if (n % 2 == 0) { Console.WriteLine("luku on parillinen"); }

            else { Console.WriteLine("luku ei ole parillinen"); }
              
        }
        static void Main(string[] args)
        {
            iseven(int.Parse(Console.ReadLine()));
        }
    }
}
