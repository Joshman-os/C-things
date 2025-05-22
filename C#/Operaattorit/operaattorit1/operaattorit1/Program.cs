using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anna kaksi lukua");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine(a + b + " on lukujen summa");
            Console.WriteLine(a - b + " on lukujen erotus");
            Console.WriteLine(a * b + " on lukujen tulo");
            Console.WriteLine(a/b + " on lukujen osamäärä");
            Console.WriteLine(a%b + " on lukujen jakojäännös");

        }
    }
}
