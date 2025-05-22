using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodit6
{
    internal class Program
    {
        static int calculatesum() 
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int counter = 0; counter < nums.Length; counter++)
            {
                sum += nums[counter];
            }
            return sum;


        }

        static void Main(string[] args)
        {
            Console.WriteLine(calculatesum());
        }
    }
}
