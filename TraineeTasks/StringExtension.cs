using System;
using System.Text.RegularExpressions;

namespace TraineeTasks
{
    public static class StringExtension
    {
        public static int GetNumberOccurrences(this string str, string substr)
        {
            if (String.IsNullOrEmpty(substr))
            {
                throw new ArgumentException(String.Format("{0} - cannot be null or emty", nameof(substr)));
            }

            return Regex.Matches(str, substr).Count;
        }
    }
}
