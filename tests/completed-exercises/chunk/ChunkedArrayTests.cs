using NUnit.Framework;
using Main.completed_exercises.chunk;
using System;
using System.Collections.Generic;
using System.Text;

namespace Main.completed_exercises.chunk.Tests
{
    [TestFixture()]
    public class ChunkedArrayTests
    {
        [Test()]
        public void ExecuteTest()
        {
            var arrayInt = new List<int> { 1, 2, 3 , 4, 5, 6, 7};

            var test = new ChunkedArray().Execute(arrayInt, 5);

            Assert.Inconclusive();
        }
    }
}