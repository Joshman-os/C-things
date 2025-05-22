using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";

            if (File.Exists(filepath))
            {
                StreamReader reader = new StreamReader(filepath);
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line.Split(' ');
                    }

                }
            }
        }
    }
}
