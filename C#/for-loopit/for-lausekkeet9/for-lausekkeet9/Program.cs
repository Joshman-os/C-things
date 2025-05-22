using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, };
            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            Console.WriteLine(nums[0] +" " + nums[1]+" "+ nums[2]+" "+nums[3] +" "+ nums[4]);
        }
    }
}
