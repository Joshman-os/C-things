using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";
            if (File.Exists(filepath)) 
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    File.Create("text.txt");
                    string line = reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        StreamWriter writer = new StreamWriter(line);
                        writer.WriteLine(line);

                    }
                }
            }
        }
    }
}
