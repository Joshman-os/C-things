using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double alv = 0.69;
            Console.WriteLine("tuotteen veroton hinta:");
           int hinta = int.Parse(Console.ReadLine());
           Console.WriteLine(hinta * alv + hinta);
        }
    }
}
