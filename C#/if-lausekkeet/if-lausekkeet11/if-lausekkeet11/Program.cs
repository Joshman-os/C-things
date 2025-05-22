using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_lausekkeet11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aseta kuukauden numero");
            int kk = int.Parse(Console.ReadLine());
            switch (kk) {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("syksy");
                    break; 
            
            
            }   
                   
        }
    }
}

