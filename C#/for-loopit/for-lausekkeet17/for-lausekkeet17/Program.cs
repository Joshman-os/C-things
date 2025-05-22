using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[5];
            int counter = 0;
            while (counter < nums.Length)
            {
                nums[counter] = int.Parse(Console.ReadLine());
                counter++;
            }
            Array.Sort(nums);
            foreach (int i in nums) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
