using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lisää luku");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 5 *2 / 3);
        }
    }
}
