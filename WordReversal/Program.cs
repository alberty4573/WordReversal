using System;
using System.Collections.Generic;

namespace WordReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement: For any given sentence, reverse the characters of each word in the sentence.

            // Please change the input 
            string input = "This is Albrt.";
            var newReverse = new WordReverse();
            var outPut = newReverse.Reverse(input);
            Console.WriteLine(outPut);
        }
    }
}
