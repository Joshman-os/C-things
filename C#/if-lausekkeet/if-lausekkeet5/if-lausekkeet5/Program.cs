using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lausekkeet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kuinka monta pistettä sait?");
            int pts = int.Parse(Console.ReadLine());
            if (pts <= 20)
            {
                Console.WriteLine("arvosanasi: hylätty");
            }
            else
            {
                if (pts <= 40)
                {
                    Console.WriteLine("arvosanasi: 1");
                }
                else
                {
                    if (pts <= 80)
                    {
                        Console.WriteLine("arvosanasi: 2");
                    }
                        else if (pts <= 100)
                        {
                        Console.WriteLine("arvosanasi: 3");
                        }

                }
            }
        }
    }
}
