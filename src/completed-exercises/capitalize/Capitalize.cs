using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.capitalize
{
    public class Capitalize
    {
        public string Execute(string inputString)
        {
            if (inputString.Length == 0)
                return "";

            var inputStringArr = inputString.Split(" ");

            var uppercaseStringArray = new List<string>();
            foreach(var word in inputStringArr)
            {
                var firstLetter = word[0].ToString().ToUpper(); ;
                var restOfWord = word.Substring(1);

                uppercaseStringArray.Add(firstLetter + restOfWord);
            }

            var capitalizedString = String.Join(" ", uppercaseStringArray);
            return capitalizedString;
        }

    }
}
