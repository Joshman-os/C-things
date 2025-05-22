using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lauseke7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("syötä merkkijono");
            string merkkijono1 = Console.ReadLine();
            string merkkijono2 = Console.ReadLine();
            
           
            if (merkkijono1 == merkkijono2) { Console.WriteLine("merkkijonot ovat samat"); }
          
        }
    }
}
