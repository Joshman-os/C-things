using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int counter = 0;
            while (counter < nums.Length)
            {
                nums[counter] = int.Parse(Console.ReadLine());
                counter++;
            }
            int highest = nums[0];
            int lowest = nums[0];
            while (counter < nums.Length)
            {
                if (nums[counter] == 69) { Console.WriteLine("luku 69 on taulukossa"); }
                counter++;
            }
            Console.WriteLine(highest);
            Console.WriteLine(lowest);
        }
    }
}
