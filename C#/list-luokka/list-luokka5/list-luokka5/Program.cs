using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            Console.WriteLine( "syötä 5 nimeä");

            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string name3 = Console.ReadLine();
            string name4 = Console.ReadLine();
            string name5 = Console.ReadLine();
            names.Add(name1);
            names.Add(name2);
            names.Add(name3);
            names.Add(name4);
            names.Add(name5);
            names.Sort();
            for (int counter = 0; counter < names.Count; counter++)
            {
                Console.WriteLine(names[counter]);
            }

        }
    }
}
