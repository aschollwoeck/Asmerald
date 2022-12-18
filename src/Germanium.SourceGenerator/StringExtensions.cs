using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Germanium.SourceGenerator
{
    internal static class StringExtensions
    {
        internal static string FirstCharToUpper(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToUpperInvariant(), input.AsSpan(1))
            };

        internal static string FirstCharToLower(this string input) =>
            input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _ => string.Concat(input[0].ToString().ToLowerInvariant(), input.AsSpan(1))
            };

        internal static ReadOnlySpan<char> FirstCharToUpper(this ReadOnlySpan<char> input) =>
            input switch
            {
                _ => string.Concat(input[0].ToString().ToUpperInvariant(), input.Slice(1))
            };

        internal static ReadOnlySpan<char> FirstCharToLower(this ReadOnlySpan<char> input) =>
            input switch
            {
                _ => string.Concat(input[0].ToString().ToLowerInvariant(), input.Slice(1))
            };

        internal static string[] SplitAt(this string input, int idx) => new string[] { input.Substring(0, idx), input.Substring(idx + 1, input.Length - idx - 1) };
    }
}
