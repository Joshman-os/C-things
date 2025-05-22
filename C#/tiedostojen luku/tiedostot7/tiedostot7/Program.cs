using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";
            if (File.Exists(filepath))
            {
                string add = Console.ReadLine();
                StreamWriter writer = new StreamWriter(filepath);
                writer.WriteLine(add); writer.Close();
                var date = DateTime.Now;
                writer.WriteLine(date); 
            }
        }
    }
}
