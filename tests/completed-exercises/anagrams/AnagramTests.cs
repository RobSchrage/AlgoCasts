using NUnit.Framework;
using Main.completed_exercises.anagrams;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.anagrams.Tests
{
    [TestFixture()]
    public class AnagramTests
    {
        [Test()]
        public void ExecuteTest()
        {
            var test = new Anagram();
            var actualResult = test.Execute("Helloss", "eHllos");

            Assert.Fail();
        }
    }
}