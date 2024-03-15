using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_4_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
                                    
            for (int i = 0, letter = 97; i < alphabet.Length; i++, letter++)
            {
                alphabet[i] = (char)letter;
            }
            foreach (char letter in alphabet) 
            {
                Console.WriteLine($"Letter:{letter} ASCII number:{(int)letter}");
            }
        }
    }
}
