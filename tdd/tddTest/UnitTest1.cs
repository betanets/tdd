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

        [TestMethod]
        public void WeatherMakerTest()
        {
            WeatherMaker wm = new WeatherMaker();
            double temperature = wm.getCurTemperatureByCityID(1510853);
            Assert.IsTrue(temperature > -40 && temperature < 40 ? true : false);
        }

        [TestMethod]
        public void WeatherMakerTestAntarctica()
        {
            WeatherMaker wm = new WeatherMaker();
            double temperature = wm.getCurTemperatureByCityID(6255152);
            Assert.IsTrue(temperature > -60 && temperature < -10 ? true : false);
        }

        [TestMethod]
        public void WeatherMakerTestSingapore()
        {
            WeatherMaker wm = new WeatherMaker();
            double temperature = wm.getCurTemperatureByCityID(1880252);
            Assert.IsTrue(temperature > 15 && temperature < 50 ? true : false);
        }

        [TestMethod]
        public void WeatherMakerTestBarnaulNskSydney()
        {
            WeatherMaker wm = new WeatherMaker();
            double temperatureBarnaul = wm.getCurTemperatureByCityID(1510853);
            double temperatureNsk = wm.getCurTemperatureByCityID(1496747);
            double temperatureSydney = wm.getCurTemperatureByCityID(2147714);

            Assert.IsTrue( (temperatureBarnaul == temperatureNsk) && (temperatureNsk == temperatureSydney) ? false : true);
        }
    }
}
