using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTranslator.Models
{
    public class Translator
    {
        
        
        public string SelectedValue { get; set; }
        
        
        public SelectList SourceLanguages { get; set; }

        public SelectList TargetLanguages { get; set; }

        
        [DataType(DataType.MultilineText)]
        public string TranslateText { get; set; }

        
        [DataType(DataType.MultilineText)]
        public string TranslateResult { get; set; }
    }
}