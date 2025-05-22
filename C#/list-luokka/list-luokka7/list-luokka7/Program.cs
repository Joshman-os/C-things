using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            for (int counter = 0; counter < 10; counter++) { int random_num = rnd.Next(0, 10);  list.Add(random_num); }
            int num = int.Parse(Console.ReadLine());
            int tracker = 0;
            for (int counter = 0;counter < 10; counter++) 
            {
                
                if (list[counter] == num)
                {
                    tracker++;
                    
                }
                
            }
            Console.WriteLine("luku esiintyy listassa " + tracker + " kertaa");
        }
    }
}
