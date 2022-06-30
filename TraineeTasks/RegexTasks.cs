using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TraineeTasks
{
    public class RegexTasks
    {
        /// <summary>
        /// Find words in a string that contain the letter h, followed by 0 or 1 letter u.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Returns a string of found words.</returns>
        public string FindWords(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            var regex = new Regex(@"\w*h(u{0}|u{1})\w*", RegexOptions.IgnoreCase);
            var matches = regex.Matches(str);
            List<string> words = new List<string>();

            foreach (Match item in matches)
            {
                if (!item.Value.Contains("uu"))
                {
                    words.Add(item.Value);
                }
            }

            if (words.Count > 0)
            {
                return words.Aggregate(((i, j) => i + ", " + j));
            }

            return "There are no matches";
        }

        public string ValidateBelarusianPhoneNumber(string phoneNumber)
        {
            if (String.IsNullOrEmpty(phoneNumber))
            {
                throw new ArgumentException("The phone number cannot be null or empty string");
            }

            const string MatchPhonePattern =
            @"\+375\s(29|33|44|25){1}\s\d{3}\s\d{2}\s\d{2}$";
            Regex regex = new Regex(MatchPhonePattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(phoneNumber);

            if (matches.Count == 1)
            {
                return matches[0].Value;
            }

            return "It is not valid phone number";
        }

        public string ValidateURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("The url cannot be null or empty string");
            }
            const string MatchPhonePattern =
            @"(http|https){1}://.+(.com|.uk|.us)$";
            Regex regex = new Regex(MatchPhonePattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(url);

            if (matches.Count == 1)
            {
                return matches[0].Value;
            }

            return "It is not valid url";
        }
    }
}
