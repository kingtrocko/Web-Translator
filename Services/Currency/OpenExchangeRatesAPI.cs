using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Services.Currency
{
    public class OpenExchangeRatesAPI
    {
        string baseUrl;
        string appId;

        public OpenExchangeRatesAPI()
        {
            baseUrl = "http://openexchangerates.org/api";
            //TODO
            // change this for the Eduardo's One
            appId = "49258a72b85547bebd12c18ec3e5ade0";
        }

        public Dictionary<string, string> GetCurrencyNames()
        {
            string urlPath = "/currencies.json";
            string json = ParseResponseAsString(HttpRequest(baseUrl + urlPath));

            Dictionary<string, string> names = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            return names;
        }

        public string ConvertCurrency(string value, string from, string to)
        {
            string uri = "https://www.google.com/finance/converter";
            List<string> parameters = new List<string>();
            parameters.Add(String.Format("a={0}", value));
            parameters.Add(String.Format("from={0}", from));
            parameters.Add(String.Format("to={0}", to));

            string urlPath = CreateRequestPath(uri, parameters);
            string htmlString = ParseResponseAsString(HttpRequest(urlPath));

            string currencyValue = ScrapeConvertedCurrencyValueWithinHTML(htmlString);

            return currencyValue;
        }

        private string ScrapeConvertedCurrencyValueWithinHTML(string HTMLAsString)
        {
            MatchCollection m1 = Regex.Matches(HTMLAsString, @"(<span.*?>.*?</span>)", RegexOptions.Singleline);
            foreach (Match m in m1)
            {
                string spanTag = m.Groups[1].Value;

                if (spanTag.Contains("bld"))
                {
                    string value = Regex.Replace(spanTag, @"\s*<.*?>\s*", "", RegexOptions.Singleline);
                    var array = Regex.Split(value, @"[^0-9\.]+").Where(c => c != "." && c.Trim() != "");

                    string tmp = "-1";

                    if (array.Count() == 1)
                       tmp = array.ElementAt(0).ToString();

                    return tmp;
                }
            }
            return "";
        }


        private string CreateRequestPath(string path, List<string> parameters)
        {
            for (int i = 0; i < parameters.Count; i++)
            {
                path += i == 0 ? "?" : "&";
                path += parameters[i];
            }
            return path;
        }


        private string ParseResponseAsString(HttpWebResponse response)
        {
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                return stream.ReadToEnd();
            }
        }

        private HttpWebResponse HttpRequest(string path)
        {
            HttpWebResponse response = null;
            try
            {
                // Creates Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);

                response = (HttpWebResponse)request.GetResponse();

                return response;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return null;
            }
        }

    }
}
