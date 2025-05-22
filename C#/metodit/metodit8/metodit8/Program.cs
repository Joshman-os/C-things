using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit8
{
    internal class Program
    {
        static void printtriangle(int n)
        {
            List<string> list = new List<string>() {"*" };
            string aster = "*";
            for (int counter  = 0; counter < n; counter++)
            {
               
                Console.WriteLine(list[counter]);
                list.Add(aster);
                aster += "*";
            }

        }
        static void Main(string[] args)
        {
            printtriangle(5);
        }
    }
}
