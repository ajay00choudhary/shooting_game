using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace shooting_test
{
    [TestClass]
    public class UnitTest1
    {
        public int scores()
        {
            return (10);
        }
        [TestMethod]
        public void TestMethod1()
        {
            int actual_scores = 10;
            UnitTest1 h = new UnitTest1();
            int expected = h.scores();
            Assert.AreEqual(actual_scores, expected, 0.01, "Game is running correctly");       }
			 public void TestMethod1()
		[TestMethod]
        public void TestMethod2()
	   {
            int actual_scores = 30;
            UnitTest1 h = new UnitTest1();
            int expected = h.scores();
            Assert.AreEqual(actual_scores, expected, 0.01, "Game is running incorrectly");       }
    }
}
