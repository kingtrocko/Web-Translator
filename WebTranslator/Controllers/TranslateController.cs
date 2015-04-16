using Services.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace WebTranslator.Controllers
{
    public class TranslateController : Controller
    {
        private readonly MicrosoftTranslatorHttpAPI translatorAPI;

        public TranslateController()
        {
            translatorAPI = new MicrosoftTranslatorHttpAPI();
        }

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Translate(string txtSource)
        {
            string result = translatorAPI.Translate(txtSource, "en", "es");
            ViewBag.Remove = result;
            return View();
        }
    }
}