using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string name1 = "matti";
            string name2 = "liisa";
            string name3 = "pekka";
            string name4 = "anna";
            names.Add(name1);
            names.Add(name2);
            names.Add(name3);
            names.Add(name4);
            Console.WriteLine("anna nimi ");
            string name = Console.ReadLine();
            if (names.Contains(name))
            {
                Console.WriteLine("nimi löytyy listalta ");
            }
            else
            {
                Console.WriteLine("nimeä ei ole listalla ");
            }
        }
    }
}
