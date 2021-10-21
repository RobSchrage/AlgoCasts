using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

// --- Directions
// Given an integer, return an integer that is the reverse
// ordering of numbers.
// --- Examples
//   reverseInt(15) === 51
//   reverseInt(981) === 189
//   reverseInt(500) === 5
//   reverseInt(-15) === -51
//   reverseInt(-90) === -9

namespace Main.completed_exercises.reverseint
{
    public class ReverseInt
    {
        public string Execute(int intToReverse)
        {
            var signString = Math.Sign(intToReverse) == -1 ? "-" : "";

            var reverseInt = signString + 
               ( new string(Math.Abs(intToReverse)
                .ToString()
                .Reverse()
                .ToArray())).TrimStart('0');

            return reverseInt;
        }
    }
}
