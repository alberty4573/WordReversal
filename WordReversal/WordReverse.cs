using System;

namespace WordReversal
{
    class WordReverse
    {
        public string Reverse(string input)
        {
            string result = "";

            // seperate each word based on space
            string[] words = input.Split(' ');
            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string newWord = new string(charArray);
                result = result + newWord + " ";
            }


            return result;
        }
    }
}
