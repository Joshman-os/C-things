using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int lightspd = 299792458;
            Console.WriteLine("aika sekuntteina");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("valon matka ajassa: " + lightspd * time);

        }
    }
}
