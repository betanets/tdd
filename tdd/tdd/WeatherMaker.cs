using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace tdd
{
    public class WeatherMaker
    {
        public double getDataFromJSON(int ID)
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            string jsonString = "";
            try
            {
                jsonString = wc.DownloadString("http://api.openweathermap.org/data/2.5/weather?id=" + ID
                    + "&appid=a234bbe9dd715c7fb108587e489bcc35");
            }
            catch(Exception ex)
            {
                return -900;
            }

            var jmas = JObject.Parse(jsonString);
            var temperatureString = jmas.First.Next.Next.Next.First.First.First.ToString();

            return Math.Round(Double.Parse(temperatureString) - 273.15, 1); //Кельвин --> Цельсий
        }


        public double getCurTemperatureByCityID(int ID)
        {
            return getDataFromJSON(ID);
        }
    }
}
