using System;
using System.Text.RegularExpressions;

namespace TraineeTasks
{
    public static class StringExtension
    {
        public static int GetNumberOfOccurrences(this string str, string substr)
        {
            if (string.IsNullOrEmpty(substr))
            {
                throw new ArgumentException(String.Format("{0} - cannot be null or emty", nameof(substr)));
            }

            return str.Split(substr).Length - 1;
        }
    }
}
