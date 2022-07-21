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
        public IEnumerable<string> FindWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException("The string cannot be null or empty string");
            }

            return Regex.Matches(str, @"\w*h[u]{0,1}[^u]\w*")
                .Select(m => m.Value);
        }

        public bool ValidateBelarusianPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("The phone number cannot be null or empty string");
            }

            const string pattern = @"\+375\s(29|33|44|25){1}\s\d{3}\s\d{2}\s\d{2}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }

        public bool ValidateUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                throw new ArgumentException("The url cannot be null or empty string");
            }

            const string pattern = @"(http|https){1}://.+(.com|.uk|.us)$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(url);
        }
    }
}
