using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.anagrams
{
    public class Anagram
    {
        public bool Execute(string stringA, string stringB)
        {
            if (stringA.Length != stringB.Length)
                return false;

            var dictA = new Dictionary<char, int>();
            var dictB = new Dictionary<char, int>();

            foreach(var c in stringA)
            {
                dictA.TryGetValue(c, out var value);
                dictA[c] = value + 1;
            }

            foreach (var c in stringB)
            {
                dictB.TryGetValue(c, out var value);
                dictB[c] = value + 1;
            }

            foreach(var k in dictA.Keys)
            {
                if(dictA[k] != dictA[k])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
