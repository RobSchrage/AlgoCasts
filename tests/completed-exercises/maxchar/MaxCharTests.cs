using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.maxchar.Tests
{
    [TestFixture()]
    public class MaxCharTests
    {
        private IDictionary<char, int> _dictionary;

        [SetUp]
        public void Init()
        {
            _dictionary = new Dictionary<char, int>();

        }

        [Test()]
        public void FindMaxCharWithBlankString()
        {
            var actualValue = new MaxChar(_dictionary).Execute("");

            Assert.AreEqual(default(char), actualValue);
        }

        [Test()]
        public void FindMaxCharWith2MaxChars()
        {
            var actualValue = new MaxChar(_dictionary).Execute("aaabbbcc");

            Assert.AreEqual('a', actualValue);
        }

        [Test()]
        public void FindMaxCharWithTrailingMaxChar()
        {
            var actualValue = new MaxChar(_dictionary).Execute("aaabbbb");

            Assert.AreEqual('b', actualValue);
        }
    }
}