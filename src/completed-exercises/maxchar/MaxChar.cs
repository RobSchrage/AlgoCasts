using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// --- Directions
// Given a string, return the character that is most
// commonly used in the string.
// --- Examples
// maxChar("abcccccccd") === "c"
// maxChar("apple 1231111") === "1"

namespace Main.completed_exercises.maxchar
{
    public class MaxChar
    {
        IDictionary<char, int> _dictionary;

        public MaxChar(IDictionary<char, int> dictionary)
        {
            _dictionary = dictionary;
        }

        public char Execute(string inputString)
        {
            if (String.IsNullOrEmpty(inputString))
                return default(char);

            foreach (var charTest in inputString)
            {
                _dictionary.TryGetValue(charTest, out var value);
                _dictionary[charTest] = value + 1;
            }

            //var maxValue = _dictionary.Values.Max();
            //var maxChar = _dictionary.FirstOrDefault(x => x.Value == maxValue).Key;

            var maxChar = _dictionary.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            return maxChar;
        }
    }
}
