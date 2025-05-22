using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int[] nums = { num1, num2, num3, num4, num5 };
            int counter = 0;
            while (counter < nums.Length) 
            {
            counter++;
                Console.WriteLine(nums[counter]);
            }
        }
    }
}
