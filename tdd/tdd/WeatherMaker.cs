using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class WeatherMaker
    {
        public int getCurTemperatureByCityID(int ID)
        {
            if (ID == 6255152)
                return -40;
            else if (ID == 1880252)
                return 30;
            return 0;
        }
    }
}
