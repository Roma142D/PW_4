using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int [50];
            int num = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                num += 2;
                nums[i] = num;
            }
            foreach (int element in nums) 
            {
                Console.WriteLine($"Element:{element}");
            }
        }
    }
}
