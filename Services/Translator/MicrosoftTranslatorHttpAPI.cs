using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Services.Translator
{
    public class MicrosoftTranslatorHttpAPI
    {
        #region Private Fields
        private Authentication authentication;
        #endregion

        #region Private Properties
        
        private string requestUri;
        private string requestPath;

        private string AccessTokenHeader
        {
            get 
            {
                return String.Format("Bearer {0}", authentication.GetAccessToken().access_token);
            }
        }

        #endregion

        #region Constructors
        public MicrosoftTranslatorHttpAPI()
        {
            authentication = new Authentication("app001-web-translator", "ckURYO1bduo0PmipUAQqMWOXCv00AC+HrSwDfLCC1QU=");
        }
        #endregion

        #region Public Methods

        public string DetectLanguage(string text)
        {
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/Detect";
            List<string> param = new List<string>();
            param.Add(String.Format("text={0}", text));

            requestPath = CreateRequestPath(requestUri, param);

            string code = ParseResponseAsString(HttpRequest(requestPath));

            return code;
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

        public Dictionary<string, string> GetLanguagesNames()
        {
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/GetLanguageNames";
            List<string> queryStringParameters = new List<string>();
            queryStringParameters.Add(String.Format("locale={0}", "en"));

            requestPath = CreateRequestPath(requestUri, queryStringParameters);

            string[] languagesCodes = GetLanguagesCodes();

            string[] languagesNames = ParseResponseAsArray(HttpRequest(requestPath, "text/xml", "POST", languagesCodes));

            var dictionary = languagesNames.Zip(languagesCodes, (s, i) => new { s, i })
                          .ToDictionary(item => item.s, item => item.i);
            return dictionary;
        }

        public string GetAudioUrl(string text, string language)
        {
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/Speak";
            List<string> queryStringParameters = new List<string>();
            queryStringParameters.Add(String.Format("appId=Bearer {0}", HttpUtility.UrlEncode(authentication.GetAccessToken().access_token)));
            queryStringParameters.Add(String.Format("text={0}", HttpUtility.UrlEncode(text)));
            queryStringParameters.Add(String.Format("language={0}", language));
            queryStringParameters.Add(String.Format("format={0}", HttpUtility.UrlEncode("audio/mp3")));

            requestPath = CreateRequestPath(requestUri, queryStringParameters);

            return requestPath;
        }


        #endregion

        #region PrivateMethods

        private string[] GetLanguagesCodes()
        {
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/GetLanguagesForTranslate";

            return ParseResponseAsArray(HttpRequest(requestUri));
        }

        private string [] ParseResponseAsArray(HttpWebResponse response)
        {
            string result = ResponseAsString(response);
            XDocument xdoc = XDocument.Parse(result);

            var list = xdoc.Root.Elements()
                           .Select(element => element.Value)
                           .ToArray();

            return list;
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

        private HttpWebResponse HttpRequest(string path, string contentType = null, string method = null, string [] data = null)
        {
            HttpWebResponse response = null;
            try
            {
                // Creates Request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);

                // Adds Secure Token to Header
                request.Headers.Add("Authorization", this.AccessTokenHeader);

                if (contentType != null)
                    request.ContentType = contentType;
                if (method != null)
                    request.Method = method;

                if (data != null) 
                {
                    DataContractSerializer dcs = new DataContractSerializer(Type.GetType("System.String[]"));
                    using (System.IO.Stream stream = request.GetRequestStream())
                    {
                        dcs.WriteObject(stream, data);
                    }
                }
                response = (HttpWebResponse)request.GetResponse();

                //string str = ResponseAsString(response);

                return response;
            }
            catch(Exception ex)
            {
                string err = ex.Message;
                return null;
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

        private string ResponseAsString(HttpWebResponse response)
        {
            using(StreamReader rdr = new StreamReader(response.GetResponseStream(), Encoding.Default))
            {
                return rdr.ReadToEnd();
            }
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
        #endregion
    }
}
