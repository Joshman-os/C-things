using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_lausekkeet11
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
            int lowest  = nums[0];
            while (counter < nums.Length)
            {
                if (highest <= nums[counter])
                {
                    highest = nums[counter];
                }
                if (lowest >= nums[counter])
                {
                    lowest = nums[counter];
                }
                counter++;
            }
            Console.WriteLine(highest);
            Console.WriteLine(lowest);



        }
    }
}
