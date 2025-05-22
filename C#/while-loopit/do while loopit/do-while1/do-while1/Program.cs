using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            string text;
            do
            {
                Console.WriteLine("anna salasana: ");
                text = Console.ReadLine();
            } 
            while (text != password);
        }
    }
}
