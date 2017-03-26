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

        [TestMethod]
        public void SayWhatAreYouDoing()
        {
            Companion companion = new Companion();
            Assert.AreNotEqual(">>> Привет!", companion.getWords("Что ты умеешь делать?"));
        }

        [TestMethod]
        public void SayGoodbye()
        {
            Companion companion = new Companion();
            Assert.AreEqual(">>> Пока!", companion.getWords("Пока"));
        }
    }
}
