using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Germanium.Generate
{
    internal static class StringExtensions
    {
        private static readonly char[] _ascii_chars = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'u', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '_'};

        internal static string ToAsciiValidString(this string str)
        {
            return String.Concat(str.Select(c => _ascii_chars.Contains(c) ? c : '_'));
        }

        internal static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpper(), input.AsSpan(1))
            };

        internal static bool ContainsOneOf(this string input, IEnumerable<string> values) {
            
            foreach (var str in values)
            {
                if (input.Contains(str)) return true;
            }

            return false;
        }

    }
}
