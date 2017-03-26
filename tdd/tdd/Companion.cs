using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class Companion
    {
        public string getWords(string words)
        {
            string replySymbols = ">>> ";
            if (words == "Что ты умеешь делать?")
                return replySymbols + "Пока ничего";
            return replySymbols + "Привет!";
        }
    }
}
