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

        private string [] GetLanguagesCodes()
        {
            requestUri = "http://api.microsofttranslator.com/V2/Http.svc/GetLanguagesForTranslate";

            return ParseResponseAsXml(HttpRequest(requestUri));
        }

        public string [] GetLanguagesNames()
        {
            requestUri = "http://api.microsofttranslator.com/V1/Http.svc/GetLanguageNames";
            List<string> queryStringParameters = new List<string>();
            queryStringParameters.Add(String.Format("locale={0}", "en"));

            requestPath = CreateRequestPath(requestUri, queryStringParameters);

            string[] languagesCodes = GetLanguagesCodes();

            return ParseResponseAsXml(HttpRequest(requestPath, "text/xml", "POST", languagesCodes));

        }


        #endregion

        #region PrivateMethods

        private string [] ParseResponseAsXml(HttpWebResponse response)
        {
            //System.Xml.XmlReader xmlReader = System.Xml.XmlReader.Create(response.GetResponseStream());
            string result = ResponseAsString(response);
            System.Xml.Linq.XDocument xdoc = System.Xml.Linq.XDocument.Parse(result, System.Xml.Linq.LoadOptions.PreserveWhitespace);
            //xmlReader.Close();

            try
            {
                using (Stream stream = response.GetResponseStream())
                {
                    DataContractSerializer dcs = new DataContractSerializer(typeof(object));
                    object myObject = dcs.ReadObject(stream);
                    if (myObject != null)
                        Debug.Write("NOT NULL");
                }
            }
            catch (Exception ex)
            {

                string errro = ex.Message;
            }

            return null;
            //using (Stream stream = response.GetResponseStream())
            //{
            //    System.Runtime.Serialization.DataContractSerializer dcs = new System.Runtime.Serialization.DataContractSerializer(typeof(ArrayOfstring));


            //    ArrayOfstring arrayofStrings = (ArrayOfstring)dcs.ReadObject(stream);
            //    Debug.WriteLine("The languages available for translation are: ");
            //    //languageCodes.ForEach(a => Console.WriteLine(a));
            //    return arrayofStrings.@string;
            //}
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
