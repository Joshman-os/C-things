using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loopit13
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
           Array.Reverse(nums);
        }
    }
}
