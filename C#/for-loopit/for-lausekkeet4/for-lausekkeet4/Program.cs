using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder asterisk = new StringBuilder();
            for (int i = 0;i<5;i++ )
            {
                asterisk.Append("*");
              
                Console.WriteLine(asterisk);
            }
        }
    }
}
