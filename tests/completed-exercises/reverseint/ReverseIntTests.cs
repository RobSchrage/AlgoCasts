using NUnit.Framework;
using Main.completed_exercises.reverseint;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.reverseint.Tests
{
    [TestFixture()]
    public class ReverseIntTests
    {
        [Test()]
        [TestCase(5, "5")]
        [TestCase(15, "51")]
        [TestCase(90, "9")]
        [TestCase(2359, "9532")]
        [TestCase(-5, "-5")]
        [TestCase(-15, "-51")]
        [TestCase(-90, "-9")]
        [TestCase(-2359, "-9532")]
        public void ExecuteTest(int intToReverse, string expectedResult)
        {
            var test = new ReverseInt();
            var actual = test.Execute(intToReverse);

            Assert.AreEqual(expectedResult, actual);
        }
    }
}