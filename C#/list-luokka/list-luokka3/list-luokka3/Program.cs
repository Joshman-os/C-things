using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int counter = 0;
            while (counter < 5)
            {
                list.Add(int.Parse(Console.ReadLine()));
                counter++;
            }
            Console.WriteLine();
            int highest = list.Max();
            int lowest = list.Min();
            Console.WriteLine(highest);
            Console.WriteLine(lowest);
        }
    }
}
