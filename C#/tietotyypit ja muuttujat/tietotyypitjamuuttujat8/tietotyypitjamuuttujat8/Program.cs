using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tietotyypitjamuuttujat8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double airthicc = 1.225; const double accel = 9.81;
            Console.WriteLine("anna korkeuden muutos");
           int height = int.Parse(Console.ReadLine());
            Console.WriteLine(accel * height * airthicc + " on ilmanpaineen muutos");
        
        }
    }
}
