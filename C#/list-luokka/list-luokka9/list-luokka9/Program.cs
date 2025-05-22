using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Random rand2 = new Random(); 
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            for (int counter = 0; counter < 5; counter++)
            {
                list.Add(rand.Next(1, 10));
                list2.Add(rand2.Next(1, 10));
            }
            list.AddRange(list2);
            for (int counter = 0; counter < 5; counter++)
            {
              Console.WriteLine(list[counter]);
            }


        }
    }
}
