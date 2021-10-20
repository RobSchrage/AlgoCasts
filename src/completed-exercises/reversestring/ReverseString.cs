// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

using System;
using System.Linq;
using System.Text;

namespace Main.completed_exercises.reversestring
{
    public class ReverseString
    {
        //public string Execute(string str)
        //{
        //    var arr = str.ToCharArray();
        //    var reversedString = "";

        //    foreach (var c in arr)
        //    {
        //        reversedString = c + reversedString;
        //    }

        //    return reversedString;
        //}

        //public string Execute(string str)
        //{
        //    var sb = new StringBuilder();

        //    foreach (var c in str)
        //    {
        //        sb.Insert(0, c);
        //    }

        //    return sb.ToString();
        //}

        public string Execute(string str)
        {
            var test = str.Aggregate("", (acc, x) => x + acc);

            return test.ToString();
        }
    }
}