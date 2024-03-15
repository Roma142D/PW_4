using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write text:");
            string text = Console.ReadLine();
            Console.Write("Which symbol you need to find:");
            var symbol = (Console.ReadLine());
            int amount = 0;
            
            string corText = text.ToLower();
            char corSymbol = char.Parse(symbol.ToLower());
            
            foreach (char i in corText)
            {
                if (i == corSymbol)
                {
                    amount++;
                }
            }
            if (amount == 0) 
            {
                Console.WriteLine($"There`re no {symbol} in {text}");
            }
            else
            {
                Console.WriteLine($"There`re {amount} {symbol}");
            }
            Console.WriteLine($"Text '{text}' include: {text.Length} symbols");

        }
    }
}
