using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet12
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
            int numsequal = nums[0] + nums[1] + nums[2] + nums[3] + nums[4] + nums[5] + nums[6] + nums[7] + nums[8] + nums[9] + nums[10];
            Console.WriteLine(numsequal / nums.Length);


        }
    }
}
