using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string janna = "Janna";
            const string matti = "Matti";
            const string petri = "Petri";
            Console.WriteLine("nykyinen lista:");
            Console.WriteLine(janna);
            Console.WriteLine(matti);
            Console.WriteLine(petri);
            List<string> list = new List<string>();
            list.Add (janna);
            list.Add (petri);
            list.Add (matti);
            Console.WriteLine("aseta nimesi ja mikä korvataan sillä:");
            Console.Write("nimesi: "); string nimi = Console.ReadLine();
            Console.Write("korvattava nimi: "); string korvattava = Console.ReadLine();
            switch (korvattava)
            {
                case janna:
                    list.Remove (janna);
                    list.Add(nimi);
                    break;
                case matti:
                    list.Remove (matti);
                    list.Add(nimi);
                    break;
                case petri:
                    list.Remove (petri);
                    list.Add(nimi);
                    break;
            }
            Console.WriteLine("nykyinen lista:");
            int counter  = 0;
            for (; counter < list.Count; counter++)
            {
                Console.WriteLine(list[counter]);
            }
            
        }
    }
}
