using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class DefaultState : ICompanionState
    {
        public string getWords(Companion companion, string words)
        {
            string replySymbols = ">>> ";
            //int i = -1;
            if (words == "Что ты умеешь делать?")
                return replySymbols + "Пока ничего";
            else if (words == "Пока")
                return replySymbols + "Пока!";
            else if (words == "Покажи погоду")
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(1510853);
            }
            else if (words == "Покажи погоду в Новосибирске")
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(1496747);
            }
            else if (words == "Покажи погоду по ID города")
            {
                companion.State = new WeatherIDState();
                return replySymbols + "Скажешь ID города?";
            }
            /*
            else if (Int32.TryParse(words, out i) && i != -1)
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(Convert.ToInt32(words));
            }
            */
            return replySymbols + "Привет!";
        }
    }
}
