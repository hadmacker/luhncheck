using System;
using System.Linq;

namespace Luhn.Core
{
    public class LuhnChecker
    {
        private static readonly Predicate<string> Check = s =>
            s.Select(c => int.Parse(new string(new[] {c})))
                .Select((v, i) => i%2 == 0 ? v*2 : v)
                .Select(v => v > 9 ? 1 + v - 10 : v)
                .Sum()%10 == 0;
        public static bool Validate(string input)
        {
            return !string.IsNullOrWhiteSpace(input)
                   && !input.ToCharArray().Any(c => !char.IsNumber(c))
                   && Check(input);
        }
    }
}