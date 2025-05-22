using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostojen_luku1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example_stream.txt";


            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("Tiedoston sisältö rivit kerrallaan:");


                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine($"Tiedostoa {filePath} ei löytynyt.");
            }

        }
    }
}
