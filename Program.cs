using System;

namespace FindPos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str1 = "The quick brown fox jumps over the lazy dog .";
            Console.WriteLine("Original string: " + str1);
            Console.WriteLine("Position of the word 'fox' in the said string: " + test(str1, "fox"));
            Console.WriteLine("Position of the word 'The' in the said string: " + test(str1, "The"));
            Console.WriteLine("Position of the word 'lazy' in the said string: " + test(str1, "lazy"));
            Console.WriteLine("Position of the word 'quick' in the said string: " + test(str1, "quick"));
            Console.WriteLine("Position of the word 'brown' in the said string: " + test(str1, "brown"));
            Console.WriteLine("Position of the word 'dog' in the said string: " + test(str1, "dog"));
            Console.WriteLine("Position of the word 'jumps' in the said string: " + test(str1, "jumps"));
            Console.WriteLine("Position of the word 'over' in the said string: " + test(str1, "over"));
        }
        public static int test(string text, string word)
        {
            return Array.IndexOf(text.Split(' '), word) + 1;
        }
    }
}
