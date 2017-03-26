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

        [TestMethod]
        public void SayCurrentWeather()
        {
            Companion companion = new Companion();
            Assert.IsTrue((companion.getWords("Покажи погоду")).Contains(">>> Сейчас на улице: "));
        }

        [TestMethod]
        public void IsCurrentWeatherCorrect()
        {
            Companion companion = new Companion();
            WeatherMaker wm = new WeatherMaker();
            double temperatureBarnaul = wm.getCurTemperatureByCityID(1510853);
            Assert.AreEqual(">>> Сейчас на улице: " + temperatureBarnaul, companion.getWords("Покажи погоду"));
        }


        [TestMethod]
        public void SayCurrentWeatherInNsk()
        {
            Companion companion = new Companion();
            WeatherMaker wm = new WeatherMaker();
            double temperatureNsk = wm.getCurTemperatureByCityID(1496747);
            Assert.AreEqual(">>> Сейчас на улице: " + temperatureNsk, companion.getWords("Покажи погоду в Новосибирске"));
        }

        [TestMethod]
        public void SayCurrentWeatherInRandomCity()
        {
            Companion companion = new Companion();
            WeatherMaker wm = new WeatherMaker();
            Random rnd = new Random();
            int cityID = rnd.Next(6553137, 6553171);

            double temperatureRnd = wm.getCurTemperatureByCityID(cityID);
            Assert.AreEqual(">>> Скажешь ID города?", companion.getWords("Покажи погоду по ID города"));
            Assert.AreEqual(">>> Сейчас на улице: " + temperatureRnd, companion.getWords(cityID.ToString()));
        }

        [TestMethod]
        public void NoNeedToShowWeatherWithoutRequest()
        {
            Companion companion = new Companion();
            WeatherMaker wm = new WeatherMaker();
            Random rnd = new Random();
            int cityID = rnd.Next(6553137, 6553171);

            double temperatureRnd = wm.getCurTemperatureByCityID(cityID);
            Assert.AreNotEqual(">>> Сейчас на улице: " + temperatureRnd, companion.getWords(cityID.ToString()));
        }

        [TestMethod]
        public void LetsReturnToDefaultState()
        {
            Companion companion = new Companion();
            WeatherMaker wm = new WeatherMaker();
            Random rnd = new Random();
            int cityID = rnd.Next(6553137, 6553171);

            double temperatureRnd = wm.getCurTemperatureByCityID(cityID);
            Assert.AreEqual(">>> Скажешь ID города?", companion.getWords("Покажи погоду по ID города"));
            Assert.AreEqual(">>> Сейчас на улице: " + temperatureRnd, companion.getWords(cityID.ToString()));
            Assert.AreEqual(">>> Пожалуйста!", companion.getWords("Спасибо"));
            Assert.AreEqual(">>> Привет!", companion.getWords("Привет"));
        }

        [TestMethod]
        public void SayCurrentExchRate()
        {
            Companion companion = new Companion();
            Assert.IsTrue((companion.getWords("Покажи курс доллара")).Contains(">>> Курс доллара: "));
        }
    }
}
