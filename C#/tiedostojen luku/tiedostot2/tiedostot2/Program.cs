using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";

            if (File.Exists(filepath))
            {
                
             string text = File.ReadAllText(filepath);
             File.Create("kopio.txt");
             File.WriteAllText("kopio.txt", text);
            }
        }
    }
}
