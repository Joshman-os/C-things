using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet15
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
            int[] nums2 = new int[10];
            int counter2 = 0;
            while (counter2 < nums2.Length)
            {
                nums2[counter2] = int.Parse(Console.ReadLine());
                counter2++;
                nums.CopyTo(nums2, 0);

            }
        }
    }
}
