using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lauseke3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta 3 lukua");
            int lukua = int.Parse(Console.ReadLine());
            int lukub = int.Parse(Console.ReadLine());
            int lukuc = int.Parse(Console.ReadLine());
            if (lukua >= lukub && lukua >= lukuc)
            {
                Console.WriteLine(lukua + " on suurin luku ensimmäisenä lukuna");
            }
            else if (lukub >= lukuc && lukub >= lukua)
            {
                Console.WriteLine(lukub + " on suurin luku toisena lukuna");
            }
            else if (lukub <= lukuc && lukua <= lukuc) { Console.WriteLine(lukuc + " on suurin luku kolmantena lukuna"); }

            
        }
    }
}
