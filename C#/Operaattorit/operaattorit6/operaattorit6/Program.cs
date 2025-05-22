using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä kaksi lukua");
           int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(a & b);
            Console.WriteLine(a | b);
            Console.WriteLine(a<<b);
            Console.WriteLine(a ^ b);
            Console.WriteLine(a >> b);
        }
    }
            
}
