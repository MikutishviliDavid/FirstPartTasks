using System;
using System.Collections.Generic;
using System.Linq;

namespace TraineeTasks
{
    public class StringFirstPartTasks
    {
        public string ChangeLetterCase(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            var result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString().ToLower() == str[i].ToString())
                {
                    result += str[i].ToString().ToUpper();
                }
                else
                {
                    result += str[i].ToString().ToLower();
                }
            }

            return result;
        }

        public string ReverseEachWord(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            string[] words = str.Split(' ');
            var result = "";

            for (int i = 0; i < words.Length; i++)
            {
                char[] stringСharacters = words[i].ToCharArray();
                Array.Reverse(stringСharacters);

                if (i != words.Length - 1)
                {
                    result += new String(stringСharacters) + " ";
                }
                else
                {
                    result += new String(stringСharacters);
                }
            }

            return result.ToLower();
        }

        public string FindLongestPalindrome(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            string[] words = str.Split(' ');
            var palindromeWords = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrome(word))
                {
                    palindromeWords.Add(word);
                }
            }

            return palindromeWords.Aggregate("", (max, cur) => max.Length > cur.Length ? max : cur);
        }

        private bool IsPalindrome(string str)
        {
            string first = str.Substring(0, str.Length / 2);
            char[] stringСharacters = str.ToCharArray();

            Array.Reverse(stringСharacters);

            string temp = new string(stringСharacters);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
