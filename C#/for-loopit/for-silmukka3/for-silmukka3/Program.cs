using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_silmukka3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku3;
            int luku1 = 1;
            for ( int luku2=0; luku2 <=99;)
            {
                luku3 = luku1 + luku2;
                luku1++;
                luku2++;
                luku1 += luku2;
                luku2 += luku3;
                Console.WriteLine(luku3 + luku2 + luku1);
            } 
        }
    }
}
