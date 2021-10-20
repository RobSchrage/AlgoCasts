using NUnit.Framework;
using Main.completed_exercises.reversestring;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.reversestring.Tests
{
    [TestFixture()]
    public class ReverseStringTests
    {
        [Test()]
        [TestCase("abcd", "dcba")]
        [TestCase("  abcd", "dcba  ")]
        public void ExecuteTest(string stringToReverse, string expected)
        {
            var test = new ReverseString();

            string actual = test.Execute(stringToReverse);

            Assert.AreEqual(expected, actual);
            //Assert.AreEqual(test.Execute("  abcd"), "dcba  ");
        }
    }
}