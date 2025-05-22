using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            for (int counter = 0; counter < 10; counter++)
            {
                
                list.Add(rand.Next(1, 101));
            }
            Console.WriteLine("nykyinen lista on: ");
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(list[counter]);
            }
            List<int> list2 = new List<int>();
            
            for (int counter = 0;counter < 10; counter++)
            {
                
                list2.Add(rand.Next(1, 101));
            }
            Console.WriteLine("uusi lista on:");
            for (int counter = 0; counter<10; counter++)
            {

                Console.WriteLine(list2[counter]);
            }
            

         }
    }
}
