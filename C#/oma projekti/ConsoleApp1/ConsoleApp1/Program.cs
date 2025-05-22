using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
        Console.WriteLine("syötä nimi");

            bool validinput = int.TryParse(Console.ReadLine(), out int number);
            if (validinput)
        {
                Console.WriteLine("hei " + number);
        }
        else
        {
                Console.WriteLine("väärin, koita uudelleen");
        }
        }
    }
}
