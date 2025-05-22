using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä totuusarvo (2 kpl) (true/false)");
            bool a = bool.Parse(Console.ReadLine());
            bool b = bool.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(" AND " + (a == b));
            Console.WriteLine(" OR " + (a!=b));
            Console.WriteLine(" NOT " + (!a));
            
        }
    }
}
