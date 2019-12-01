using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeNumberSum.Test
{
    [TestFixture]
    class ThreeNumberSumTests
    {


       [Test]
        public void ThreeNumberSum_PassValues_ReturnCorrectTriples()
        {
            var actual = Program.ThreeNumberSum(new int[] { 12, 3, 1, 2, -6, 5, -8, 6 }, 0);
            var expected = new List<int[]> { new int[] { -8, 2, 6 }, new int[] { -8, 3, 5 }, new int[] { -6, 1, 5 } };

            Assert.AreEqual(expected , actual);
        }


    }
}
