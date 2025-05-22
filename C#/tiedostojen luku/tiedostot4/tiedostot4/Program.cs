using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiedostot4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "example.txt";

            if (File.Exists(filepath))
            { 
                File.ReadAllText(filepath);
                string keyword = "example";
                
                if (keyword == File.ReadAllText(filepath))
                {
                    StreamWriter write2 = new StreamWriter("text.txt");
                    write2.Write("");
                }
                StreamWriter write = new StreamWriter("text.txt");

            }
        }
    }
}
