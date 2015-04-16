using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Services.Translator
{
    public class MicrosoftTranslatorHttpAPI
    {
        private Authentication authentication;
        private string requestUri { get; set; }
        private string requestPath { get; set; }

        private string AccessTokenHeader
        {
            get 
            {
                return String.Format("Bearer {0}", authentication.GetAccessToken().access_token);
            }
        }
        
        public MicrosoftTranslatorHttpAPI()
        {
            authentication = new Authentication("app001-web-translator", "ckURYO1bduo0PmipUAQqMWOXCv00AC+HrSwDfLCC1QU=");
        }

        public string DetectLanguage(string text)
        {
            return "";
        }

        public string Translate(string textToTranslate, string from, string to)
        {
            
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/Translate";
            List<string> queryStringParameters = new List<string>();
            queryStringParameters.Add(String.Format("text={0}", HttpUtility.UrlEncode(textToTranslate)));
            queryStringParameters.Add(String.Format("from={0}", from));
            queryStringParameters.Add(String.Format("to={0}", to));
            queryStringParameters.Add(String.Format("contentType={0}", "text/plain"));

            requestPath = CreateRequestPath(requestUri, queryStringParameters);

            return ParseResponseAsString(HttpRequest(requestPath));
        }

        private string ParseResponseAsString(HttpWebResponse response)
        {
            string responseAsString;
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(Type.GetType("System.String"));
                responseAsString = (string)dcs.ReadObject(stream);
                return responseAsString;
            }
        }

        private HttpWebResponse HttpRequest(string path)
        {
            HttpWebResponse response = null;

            try
            {
                // Creates Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);

                // Adds Secure Token to Header
                request.Headers.Add("Authorization", this.AccessTokenHeader);

                response = (HttpWebResponse)request.GetResponse();

                return response;
            }
            catch
            {
                throw;
            }

            //finally
            //{
            //    if (response != null)
            //    {
            //        response.Close();
            //        response = null;
            //    }
            //}
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
    }
}
