using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_silmukka5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount = 25;
            
            for (int num = 1; num < amount + 1; num++)
            {
                
                Console.Write(num);
                Console.Write(" ");
                if (num % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
           
        }
    }
}
