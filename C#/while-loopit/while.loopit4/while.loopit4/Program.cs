using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while.loopit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber = rand.Next(1, 101);
            Console.WriteLine("arvaa luku");
            int guess = int.Parse(Console.ReadLine());
            while (guess != secretNumber)
            {
                if (guess > secretNumber) { Console.WriteLine("liian suuri"); }
                else if (guess < secretNumber) { Console.WriteLine("liian pieni"); }
                guess = int.Parse(Console.ReadLine());
            }
            if (guess == secretNumber) { Console.WriteLine("arvasit"); }
        }
    }
}
