using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTranslator.Models
{
    public class Translator
    {
        public string TranslatedText { get; set; }
        public string SelectedLanguageCode { get; set; }
        public IEnumerable<SelectListItem> Languages { get; set; }
    }
}