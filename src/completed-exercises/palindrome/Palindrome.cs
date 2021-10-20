using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Main.completed_exercises.Palindrome
{
    public class Palindrome
    {
        public bool Execute(string inputString)
        {
            var inputStringReversed = new string(inputString.Reverse().ToArray());
            bool isPalindrome;

            if (inputString == inputStringReversed)
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }

            return isPalindrome;
        }
    }
}
