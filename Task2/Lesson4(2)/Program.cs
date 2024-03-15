using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] ranNums = new int[40];
            int [] pairNums = new int[40];
            Random r = new Random();
            int amount = 0;

            for (int i = 0; i < ranNums.Length; i++)
            {
                ranNums[i] = r.Next(0,100);
            }

            int lenPairNums = 0;
            
            foreach (var i in ranNums)
            {
                
                if(i % 2 == 0)
                {
                    amount++;
                    pairNums[lenPairNums] = i;
                    lenPairNums ++;
                }
            }
            Console.WriteLine($"Array includes {amount} pair numbers");
            Console.Write($"It`s ");
            for (int i = 0;i < pairNums.Length; i++)
            {
                if (pairNums[i] > 0)
                {
                    Console.Write($"{pairNums[i]},");
                }
            }
        }
    }
}
