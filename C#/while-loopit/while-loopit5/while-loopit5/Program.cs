using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loopit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 0;
            int luku2 = 1;
            int luku3 = 0; 
            int counter = 0;
            while (counter != 9)
            {
              
                luku3 = luku2;
                luku2 += luku1;
                luku1 = luku3;
                
                Console.WriteLine(luku1);
              
                counter++;

            }
                
        }
    }
}
