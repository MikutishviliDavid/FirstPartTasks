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
        /// <returns>Returns a collection of strings with found words.</returns>
        public string[] FindWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            return Regex.Matches(str, @"\w*h[u]{0,1}[^u]\w*", RegexOptions.IgnoreCase)
                .Cast<Match>()
                .Select(m => m.Value)
                .ToArray();
        }

        public bool ValidateBelarusianPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("The phone number cannot be null or empty string");
            }

            const string MatchPhonePattern =
            @"\+375\s(29|33|44|25){1}\s\d{3}\s\d{2}\s\d{2}$";
            Regex regex = new Regex(MatchPhonePattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(phoneNumber);

            return matches.Count == 1;
        }

        public bool ValidateURL(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("The url cannot be null or empty string");
            }

            const string MatchPhonePattern =
            @"(http|https){1}://.+(.com|.uk|.us)$";
            Regex regex = new Regex(MatchPhonePattern, RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(url);

            return matches.Count == 1;
        }
    }
}
