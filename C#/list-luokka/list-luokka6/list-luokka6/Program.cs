using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_luokka6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int counter = 0; counter < 10; counter++)
            { 
             list.Add(int.Parse(Console.ReadLine()));
            }
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine(list[counter]);
            }
            list.Reverse();
            for (int counter = 0;counter < 10; counter++)
            {
                
                Console.WriteLine(list[counter]);
            }

        }
    }
}
