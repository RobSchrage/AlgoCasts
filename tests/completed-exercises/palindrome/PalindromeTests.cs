using NUnit.Framework;
using Main.completed_exercises.Palindrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.Palindrome.Tests
{
    [TestFixture()]
    public class PalindromeTests
    {
        [Test()]
        [TestCase("aba", true)]
        [TestCase(" aba", false)]
        [TestCase("aba ", false)]
        [TestCase("greetings", false)]
        [TestCase("1000000001", true)]
        [TestCase("Fish hsif", false)]
        [TestCase("pennep", true)]
        public void ExecuteTest(string strToCheck, bool isPalindrome)
        {
            var test = new Palindrome();
            var actual = test.Execute(strToCheck);

            Assert.AreEqual(isPalindrome, actual);
        }
    }
}
