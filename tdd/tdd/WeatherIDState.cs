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

            bool result = Int32.TryParse(words, out num);
            if (result)
            {
                WeatherMaker wm = new WeatherMaker();
                return replySymbols + "Сейчас на улице: " + wm.getCurTemperatureByCityID(Convert.ToInt32(words));
            }
            else
                return replySymbols + "Кажется, что-то не так с ID города";
        }
    }
}
