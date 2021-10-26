using NUnit.Framework;
using Main.completed_exercises.fizzbuzz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.fizzbuzz.Tests
{
    [TestFixture()]
    public class FizzBuzzTests
    {
        [Test()]
        public void ExecuteTest()
        {
            new FizzBuzz().Execute(31);

            Assert.Inconclusive();
        }
    }
}