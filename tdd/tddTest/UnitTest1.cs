using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using tdd;

namespace tddTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SayHello()
        {
            Companion companion = new Companion();
            Assert.AreEqual(">>> Привет!", companion.getWords("Привет"));
        }
    }
}
