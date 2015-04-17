using Services.Translator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTranslator.Models;


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
            Dictionary<string, string> languages = translatorAPI.GetLanguagesNames();

            var model = new Translator
            {
                SourceLanguages = new SelectList(languages, "Value", "Key"),
                TargetLanguages = new SelectList(languages, "Value", "Key"),
                SelectedValue = "es"
            };
            return View(model);
        }

        [HttpPost]
        //[ActionName("Index")]
        public ActionResult Translate(string txtSource)
        {
            //string result = translatorAPI.Translate(txtSource, "en", "es");
           
            //ViewBag.Remove = result;
            return View();
        }
    }
}