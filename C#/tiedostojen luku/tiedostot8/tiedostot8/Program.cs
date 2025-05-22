using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";

            if (File.Exists(filepath))
            {
                File.ReadAllText(filepath);
                string keyword = "koira";
                int counter = 0;
                if (keyword == File.ReadAllText(filepath))
                {
                    counter++;
                }
                Console.WriteLine(counter);

                

            }
            Console.ReadLine();
        }
    }
}
