using System;
using System.Collections.Generic;
using System.Linq;

namespace TraineeTasks
{
    public class StringTasks
    {
        public string ChangeLetterCase(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            var chars = str.Select(ReverseCharCase);

            return string.Concat(chars);
        }

        private char ReverseCharCase(char ch)
        {
            return char.ToLower(ch) == ch ? char.ToUpper(ch) : char.ToLower(ch);
        }

        public string ReverseEachWord(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            var reversedWords = str.Split(' ').Select(ReverseWord) ;

            return string.Join(' ', reversedWords);
        }

        private string ReverseWord(string str)
        {
            return string.Concat(str.Reverse());
        }

        public string FindLongestPalindrome(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            string[] words = str.Split(' ');
            var longestPalindrome = string.Empty;

            foreach (var word in words)
            {
                if (IsPalindrome(word) && word.Length > longestPalindrome.Length)
                {
                    longestPalindrome = word;
                }
            }

            return longestPalindrome;
        }

        private bool IsPalindrome(string str)
        {
            var first = str.Substring(0, str.Length / 2);

            var reversedStr = string.Concat(str.Reverse());

            string second = reversedStr.Substring(0, reversedStr.Length / 2);

            return first.Equals(second);
        }
    }
}
