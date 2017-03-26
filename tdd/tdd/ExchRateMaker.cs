using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tdd
{
    public class ExchRateMaker
    {
        public double getDataFromJSON()
        {
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;

            string jsonString = wc.DownloadString("https://query.yahooapis.com/v1/public/yql?q=select+*+from+yahoo.finance.xchange+where+pair+=+%22USDRUB,EURRUB%22&format=json&env=store%3A%2F%2Fdatatables.org%2Falltableswithkeys&callback=");
            var jmas = JObject.Parse(jsonString);
            var res = jmas.First.First.First.Next.Next.Next.First.First.First.First.First.Next.Next.First.ToString();
            return Double.Parse(res, System.Globalization.CultureInfo.InvariantCulture);
        }

        public double getCurExchRate()
        {
            return getDataFromJSON();
        }
    }
}
