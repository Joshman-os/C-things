using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int luku = 2;
            while (luku != 100)
            {
                Console.WriteLine(luku); luku++; luku++;
                if (luku == 98)
                {
                    Console.WriteLine(luku); luku++; luku++; Console.WriteLine(luku);
                }
            }


        }
    }
}
