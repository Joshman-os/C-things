using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operaattorit9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("määritä piste x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("määritä piste y: ");
            int y = int.Parse(Console.ReadLine());
            if (x <= 0 && y <= 0)
            {
                Console.WriteLine("pisteesi ei ole kuution sisällä");

            }
            else if (x <= 10 && y <= 10)
            {
                Console.WriteLine("syöttämäsi piste on kuution sisällä");
            }
            else
            {
                Console.WriteLine("pisteesi ei ole kuution sisällä");
               
            }
        }
    }
}
