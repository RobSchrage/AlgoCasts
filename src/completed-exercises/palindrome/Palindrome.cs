using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Main.completed_exercises.Palindrome
{
    public class Palindrome
    {
        //public bool Execute(string inputString)
        //{
        //    var inputStringReversed = new string(inputString.Reverse().ToArray());
        //    bool isPalindrome = inputString == inputStringReversed;
        //    return isPalindrome;
        //}

        public bool Execute(string inputString)
        {

            var matchCount =
                Enumerable.Range(1, (inputString.Length / 2) + 1)
                .Count(i =>
                {
                    return inputString[i - 1] != inputString[inputString.Length - i];
                });
            
            return matchCount == 0;
        }
    }
}
