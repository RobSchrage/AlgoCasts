using NUnit.Framework;
using Main.completed_exercises.capitalize;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.capitalize.Tests
{
    [TestFixture()]
    public class CapitalizeTests
    {
        [Test()]
        public void ExecuteTest()
        {
            var test = new Capitalize();
            var result = test.Execute("a lazy log");

            Assert.AreEqual("A Lazy Log", result);
        }
    }
}