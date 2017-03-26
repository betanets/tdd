using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class WeatherIDState : ICompanionState
    {
        public string getWords(Companion companion, string words)
        {
            string replySymbols = ">>> ";
            int num;

            if(words == "Спасибо")
            {
                companion.State = new DefaultState();
                return replySymbols + "Пожалуйста!";
            }

            bool result = Int32.TryParse(words, out num);
            if (result)
            {
                WeatherMaker wm = new WeatherMaker();
                double temperature = wm.getCurTemperatureByCityID(Convert.ToInt32(words));
                if (temperature == -500)
                    return "Упс! Кажется, города с таким ID не существует";
                return replySymbols + "Сейчас на улице: " + temperature;
            }
            else
                return replySymbols + "Кажется, что-то не так с ID города";
        }
    }
}
