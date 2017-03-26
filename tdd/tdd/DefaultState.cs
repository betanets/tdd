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
            if (words == "Что ты умеешь делать?")
                return replySymbols + "Показывать погоду\n" + 
                        replySymbols + "Показывать курсы валют";
            if(words == "Команды")
            {
                return replySymbols + "Показать погоду в Барнауле: <Покажи погоду>\n" + 
                    replySymbols + "Показать погоду в Новосибирске: <Покажи погоду в Новосибирске>\n" + 
                    replySymbols + "Показать погоду в другом городе: <Покажи погоду по ID города> ==> <ID города>\n" + 
                    replySymbols + "Показать курс доллара: <Покажи курс доллара>\n" + 
                    replySymbols + "Показать курс евро: <Покажи курс евро>\n" + 
                    replySymbols + "Завершить общение: <Пока>\n" + 
                    replySymbols + "Показать общую информацию о боте: <Что ты умеешь делать?>\n" +
                    replySymbols + "Показать эту справку: <Команды>";
            }
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
            else if(words == "Покажи курс доллара")
            {
                ExchRateMaker erm = new ExchRateMaker();
                return replySymbols + "Курс доллара: " + erm.getCurExchRate();
            }
            else if (words == "Покажи курс евро")
            {
                ExchRateMaker erm = new ExchRateMaker();
                return replySymbols + "Курс евро: " + erm.getCurExchRateEUR();
            }
            return replySymbols + "Привет!";
        }
    }
}
